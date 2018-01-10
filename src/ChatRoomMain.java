import java.io.IOException;
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
		System.out.println(s.getLocalAddress());
		s.close();
	}
	
	public static void host() throws IOException{
		ServerSocket s = new ServerSocket(12345);
		Socket conn = s.accept();
		System.out.println(conn.getInetAddress());
		conn.close();
		s.close();
	}
	
	public static void main(String[] args) throws UnknownHostException{
		ip = InetAddress.getLocalHost().getHostAddress();
		System.out.println(ip);
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
	}
}
