import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.InetAddress;
import java.net.ServerSocket;
import java.net.Socket;
import java.net.UnknownHostException;
import java.util.Scanner;

public class ChatRoomMain {
	/**
	 * Carson F Klein
	 * Andrew G Struthers
	 * 
	 */
	static String ip;
	static Scanner input = new Scanner(System.in);
	
	public static void client() throws UnknownHostException, IOException{
		System.out.print("Enter host ip address: ");
		String host_ip = input.nextLine();
		Socket s = new Socket(host_ip ,12345);
		
		BufferedReader recv = new BufferedReader(new InputStreamReader(s.getInputStream()));
		PrintWriter send = new PrintWriter(s.getOutputStream(), true);
		
		String msg = recv.readLine();
		System.out.println(msg);
		
		send.println("Oof");
		
		
		
		send.close();
		recv.close();
		s.close();
	}
	
	public static void host() throws IOException{
		ServerSocket s = new ServerSocket(12345);
		Socket conn = s.accept();
		
		BufferedReader recv = new BufferedReader(new InputStreamReader(conn.getInputStream()));
		PrintWriter send = new PrintWriter(conn.getOutputStream(), true);
		
		while(true){
			String msg = recv.readLine();
			System.out.print(msg);
			
			
			
			
			
			if(msg.equalsIgnoreCase("end_host")){
				break;
			}
		}	
		
		send.close();
		recv.close();
		conn.close();
		s.close();
	}
	
	public static void main(String[] args) throws IOException{
		ip = InetAddress.getLocalHost().getHostAddress();
		System.out.println("My computer IP: " + ip);
		
		/*
		 * TODO we need to either call client() to connect, or host() to open
		 * we need to call host() first, theoretically it should run on two different computers
		 * if(this computer is host){
		 * 	host();
		 * }
		 * else{
		 * 	client();
		 * }
		 */
		
		System.out.print("Enter 'host' for host, 'client' for client: ");
		String user_input = input.nextLine();
		if(user_input.equalsIgnoreCase("host")){
			host();
		}
		else{
			client();
		}		
	}
}
