/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.testwhilebo;

import java.util.ArrayList;
import java.util.Iterator;

/**
 *
 * @author xavi
 */
public class While {

    public static void main(String[] args) {
        System.out.println("Hello World!");
    }
    
    public static int LlistatAssignatures(ArrayList assignatures){
        
        int comptador = 0;
        Iterator iter = assignatures.iterator();
        
        while(iter.hasNext()){
            Assignatura element = (Assignatura) iter.next();
            if(element.isDisponible() == true){
                System.out.println(element.getNom());
                comptador = comptador +1;
            }
        }
        
        return comptador;
        
    }
    
}
