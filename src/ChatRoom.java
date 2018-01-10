import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.InetAddress;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class ChatRoom {
    /**
     * Carson F Klein
     * Andrew G Struthers
     *
     */

    private static Scanner input = new Scanner(System.in);

    private static void client() throws IOException{
        System.out.print("Enter host ip address: ");
        String host_ip = input.nextLine();
        Socket s = new Socket(host_ip ,12345);

        BufferedReader recv = new BufferedReader(new InputStreamReader(s.getInputStream()));
        PrintWriter send = new PrintWriter(s.getOutputStream(), true);

        List<String> ALL_MSG = new ArrayList<>();
        while(true){
            System.out.println("Type your message here: ");
            String user_input = input.nextLine();
            send.println(user_input);



            if(user_input.equalsIgnoreCase("read_all_msg")){
                String host_msg = recv.readLine();
                while(!host_msg.equalsIgnoreCase("END")){
                    ALL_MSG.add(host_msg);
                    host_msg = recv.readLine();
                }
                System.out.println(ALL_MSG);
            }
            if(user_input.equalsIgnoreCase("end_host")){
                break;
            }
        }

        send.close();
        recv.close();
        s.close();
    }

    private static void host() throws IOException{
        ServerSocket s = new ServerSocket(12345);
        Socket conn = s.accept();

        BufferedReader recv = new BufferedReader(new InputStreamReader(conn.getInputStream()));
        PrintWriter send = new PrintWriter(conn.getOutputStream(), true);

        List<String> ALL_MSG = new ArrayList<>();
        while(true){
            String msg = recv.readLine();
            ALL_MSG.add(msg);


            if(msg.equalsIgnoreCase("read_all_msg")){
                for(String user_msg : ALL_MSG){
                    send.println(user_msg);
                }
                send.println("END");
            }
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
        String ip = InetAddress.getLocalHost().getHostAddress();
        System.out.println("My computer IP: " + ip);

        /*
         * TODO we need to either call client() to connect, or host() to open
         * we need to call host() first, theoretically it should run on two different computers
         * if(this computer is host){
         *      host();
         * }
         * else{
         *      client();
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
