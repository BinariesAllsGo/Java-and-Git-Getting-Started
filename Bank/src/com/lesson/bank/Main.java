package com.lesson.bank;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        CheckingAccount c1 = new CheckingAccount("Obama", 100.50); // creates a new object of Checking Account class.
        
        System.out.println("Type the amount to withdraw of the Account " + c1.getAccountNumber());

        Scanner Scan = new Scanner(System.in);
        double amount = Scan.nextDouble();
        c1.withdraw(amount);

        System.out.println("Conta c1: " + c1.bank + ", " + c1.getAccountNumber() + ", " + c1.getName() + ", " + c1.getBalance());

        CheckingAccount c2 = new CheckingAccount("Diana", 543.90); // creates a new object of Checking Account class.
        
        System.out.println("Type the amount to withdraw of the Account: " + c2.getAccountNumber());

        double amount2 = Scan.nextDouble();
        c2.withdraw(amount2);

        System.out.println("Conta c2: " + c2.bank + ", " +  c2.getAccountNumber() + ", " + c2.getName() + ", " + c2.getBalance());

    }
}
