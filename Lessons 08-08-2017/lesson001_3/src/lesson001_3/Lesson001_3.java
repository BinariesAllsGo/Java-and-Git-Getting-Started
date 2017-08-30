
package lesson001_3;

import java.util.Scanner;

public class Lesson001_3 {

   
    public static void main(String[] args) {
        
        Scanner in = new Scanner(System.in);
        
        System.out.println("------------Extremely Important Program 3------------");
        System.out.println("Does: Incredible Loop");
        System.out.println("Type a number.... I mean... Just if you want:");
        int numberTyped = in.nextInt();
        for (int i = 0; i < numberTyped; i++) {
            System.out.print(i + ", ");
        }
        
        
    }
    
}
