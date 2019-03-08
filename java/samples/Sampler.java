import java.util.*;
import java.io.*;
import java.text.*;
import java.math.*;


public class Sampler {

    public static void main(String[] args){

        // sample program that utilizes scanner class
        // for standard input and output
        Scanner scanner = new Scanner(System.in);
        System.out.print("Please enter a string: ");
        // nextLine() can be used to read in buffer
        String myString = scanner.next();
        System.out.print("Please enter a integer: ");
        int myInt = scanner.nextInt();
        System.out.print("Please enter a double: ");
        double mydouble = scanner.nextDouble();

        System.out.println("Your string is: " + myString);
        System.out.println("Your integer is: " + myInt);
        System.out.printf("Your integer printed via printf: %6.2f ",19.8);
        System.out.println();
        
        // sample program that utilizes if-else statement
        System.out.print("Please enter a integer: ");
        int n = scanner.nextInt();
        scanner.close();
        String answer = "";

        // if odd print odd
        if (n%2==1){
            answer = "odd";
        }
        else{
            if (n>=2 && n <=5){
                answer = "2-5";
            }

            if (n>=6 && n <=20){
                answer = "6-20";
            }
            
            if (n>20){
                answer = ">20";
            }
        }

        System.out.println(answer);

    }
}