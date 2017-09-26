package com.lesson.polymorphism.test;

import java.util.ArrayList;


class Animal {
    
    public String toString(){

        return "Animal 123";

    }

}

class Dog extends Animal {

    public String toString(){
        
        return "Dog 123";
        
    }
}

class Horse extends Animal {

    public String toString(){

        return "Horse 123";

    }
}

class Fruit {}
class Avocado extends Fruit {}
class Pear extends Fruit{}


public class PolymorphismTest {

    public static void main(String[] args) {
        
        Animal anyAnimal;
        Fruit anyFruit;
        
        ArrayList<Animal> animals = new ArrayList<Animal>();
        animals.add(new Animal());
        animals.add(new Dog());
        animals.add(new Horse());
        
        for (Animal animal : animals){
            System.out.println(animal);
        }
        
        /*
        anyAnimal = new Animal();
        System.out.println(anyAnimal);
        anyAnimal = new Dog();
        System.out.println(anyAnimal);
        anyAnimal = new Horse();
        System.out.println(anyAnimal);
        
        Horse horse = new Horse();
        
        anyFruit = new Fruit();
        System.out.println(anyFruit);
        anyFruit = new Avocado();
        System.out.println(anyFruit);
        anyFruit = new Pear();
        System.out.println(anyFruit);
        */
               
    }
}
