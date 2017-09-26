package com.lesson.bank;

public class CheckingAccount {
    
    private static int numberOfAccountsCreated = 1;
    public String bank = "BB";
    private int accountNumber;
    private String name;
    private double balance;

    public CheckingAccount(String name, double balance) { // constructor of CheckingAccount class that receives 3 parameters.
        this.accountNumber = numberOfAccountsCreated;
        this.name = name;
        this.balance = balance;
    }

    public int getAccountNumber() {
        return accountNumber;
    }

    public void setAccountNumber(int accountNumber) {
        this.accountNumber = accountNumber;
    }

    public String getName() {
        return name.toUpperCase();
    }

    public void setName(String name) {
        this.name = name;
    }

    public double getBalance() {
        return balance;
    }

    public void deposit(double amount) {
        balance = balance + amount;
    }

    public void withdraw(double amount) {

        if (amount <= balance) {
            if (amount <= 1000) {
                balance = balance - amount;
            } else {
                System.out.println("Only withdraws bellow or equal R$ 1000 are allowed !!!");
            }
        }
        else
        {
            System.out.println("The amount you are trying to withdraw is less than the balance !!!");
        }
    }
}
