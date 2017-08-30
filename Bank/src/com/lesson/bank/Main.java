package com.lesson.bank;

import java.io.IOException;
import java.util.Scanner;


public class Main {


    public static void main(String[] args) throws IOException {
        
        CheckedAccount c1 = new CheckedAccount("Obama", 100.50);
        c1.setBank("BB");
        
        Scanner Scan = new Scanner(System.in);
        
        System.out.println("Type an amount to withdraw in account " + c1.getAccountNumber());
        double amount = Scan.nextDouble();
        
        c1.withdraw(amount);
        
        System.out.println("Conta c1: " + c1.getBank() + ", " + c1.getAccountNumber() + ", " + c1.getName() + ", " + c1.getBalance());
        System.out.println("\nPress any key to continue...\n");
        
        System.in.read();
        
    

        CheckedAccount c2 = new CheckedAccount("Diana", 543.70);
        c2.setBank("Bradesco");
        
        System.out.println("Type an amount to withdraw in account " + c2.getAccountNumber());
        double amount2 = Scan.nextDouble();
        
        c1.withdraw(amount2);
        
        System.out.println("Conta c2: " + c2.getBank() + ", " + c2.getAccountNumber() + ", " + c2.getName() + ", " + c2.getBalance());
        System.out.println("\nPress any key to continue...\n");
        
        System.in.read();



        System.out.println("Conta c2: " + c2.getAccountNumber() + ", " + c2.getName() + ", " + c2.getBalance());

        
    }
    
}
