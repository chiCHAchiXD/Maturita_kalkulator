package pkg4c_05_06_pr_kalkulator;

import java.util.Random;
import java.util.Stack;

public class Kalkulator 
{
    public static int[] generovatPole(int pocetPrvku)
    {
        /*
        Random losovaciZarizeni = new Random();
        int[] pole = new int[pocetPrvku];
        for (int i = 0; i < pole.length; i++) 
        {
            pole[i] = losovaciZarizeni.nextInt(100);
        }
        return pole;
        */
        return Kalkulator.generovatPole(pocetPrvku, 100);
    }
    
    public static int[] generovatPole(int pocetPrvku, int rozsahPrvku)
    {
        Random losovaciZarizeni = new Random();
        int[] pole = new int[pocetPrvku];
        for (int i = 0; i < pole.length; i++) 
        {
            pole[i] = losovaciZarizeni.nextInt(rozsahPrvku);
        }
        return pole;
    }
    
    public static void vypsat(int[] pole)
    {
        for (int i = 0; i < pole.length; i++) 
        {
            System.out.print(pole[i] + " ");
        }
        System.out.println();
    }
    
    public static void vypsatPozpatku(int[] pole)
    {
        Stack zasobnik = new Stack();
        
        for (int i = 0; i < pole.length; i++) 
        {
            zasobnik.push(pole[i]);
        }
        for (int i = 0; i < pole.length; i++) 
        {
            System.out.print(zasobnik.pop() + " ");
        }    
        System.out.println();
    }
    
    public static int zpracovatDelka(int[] pole)
    {
        return pole.length;
    }
    
    public static int zpracovatSoucet(int[] pole)
    {
        int soucet = 0;
        for (int i = 0; i < pole.length; i++) 
        {
            soucet += pole[i];
        }
        return soucet;
    }
    
    public static double zpracovatArPrumer(int[] pole)
    {
        int soucet = Kalkulator.zpracovatSoucet(pole);
        int pocet = Kalkulator.zpracovatDelka(pole);
        return (double)soucet / (double)pocet;
    }
    
    public static int zpracovatMaximum(int[] pole)
    {
        int max = pole[0];
        for (int i = 1; i < pole.length; i++)
        {
            if (pole[i] > max) 
            {
                max = pole[i];
            }
        }
        return max;        
    }
    
    public static int zpracovatMinimum(int[] pole)
    {
        int min = pole[0];
        for (int i = 1; i < pole.length; i++)
        {
            if (pole[i] < min) 
            {
                min = pole[i];
            }
        }
        return min;        
    }
    
    public static int[] zpracovatSeraditVzestupne(int[] pole)
    {
        int[] polePom = pole.clone();
        
        for (int i = 0; i < polePom.length-1; i++) 
        {
            for (int j = 0; j < polePom.length-1; j++) 
            {
                if (polePom[j] > polePom[j+1]) 
                {
                    int pom = polePom[j];
                    polePom[j] = polePom[j+1];
                    polePom[j+1] = pom;
                }
            }
        }
        return polePom;
    }            
    
    public static boolean zpracovatVyhledatPrvek(int[] pole, int hledaneInt)
    {
        for (int i = 0; i < pole.length; i++) 
        {
            if (pole[i] == hledaneInt)
            {
                return true;
            }
        }
        return false;
    }
    
    public static double[][] generovatPole2D(int pocetRadku, int pocetSloupcu)
    {
        Random losovaciZarizeni = new Random();
        double[][] pole2D = new double[pocetRadku][pocetSloupcu];
        for (int i = 0; i < pocetRadku; i++) 
        {
            for (int j = 0; j < pocetSloupcu; j++) 
            {
                pole2D[i][j] = losovaciZarizeni.nextDouble();
            }
        }
        return pole2D;
    }    
    
    public static void vypsat(double[][] pole2D)
    {
        for (int i = 0; i < pole2D.length; i++) 
        {
            for (int j = 0; j < pole2D[i].length; j++) 
            {
                System.out.print(pole2D[i][j] + " ");
            }
            System.out.println();
        }
        System.out.println();
    }
    
}
