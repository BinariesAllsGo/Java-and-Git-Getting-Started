package com.lesson.inheritage.shirt;

public class UseShirt {

    public static void main(String[] args) {
        
        Shirt shirt = new Shirt();
        System.out.println(shirt.getClass());
        System.out.println(shirt.getClass().getSimpleName());
        System.out.println(shirt.hashCode());
    }
}
