package com.lesson.bank;

public class CheckedAccount {

    private  static int contAccountNumber = 1;
    private String  bank;
    private int accountNumber;
    private String name;
    private double balance;

    public void deposit(double amount) {
        balance = balance + amount;
    }

    public void withdraw(double amount) {
        if (amount <= balance) {
            if (amount <= 1000) {
                balance = balance - amount;
            }
            else{
                System.out.println("Only R$1000 or bellow withdraws are allowed !!!");
            }     
        }
        else{
            System.out.println("No suficient founds !!!");
        }
        
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

    public void setname(String name) {
        this.name = name;
    }

    public CheckedAccount(String name, double balance) {
        this.accountNumber = contAccountNumber;
        this.name = name;
        this.balance = balance;
        contAccountNumber ++;
    }

    public double getBalance() {
        return balance;
    }
    
    public String getBank() {
        return bank;
    }
    
    public void setBank( String bank) {
        this.bank = bank;
    }

}
