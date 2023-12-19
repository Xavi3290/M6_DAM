/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit5TestClass.java to edit this template
 */
package com.mycompany.testwhilebo;

import java.util.ArrayList;
import java.util.Iterator;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.Order;

/**
 *
 * @author xavi
 */
public class WhileTest {
    
    public WhileTest() {
    }

    @org.junit.jupiter.api.BeforeAll
    public static void setUpClass() throws Exception {
    }

    @org.junit.jupiter.api.AfterAll
    public static void tearDownClass() throws Exception {
    }

    @org.junit.jupiter.api.BeforeEach
    public void setUp() throws Exception {
    }

    @org.junit.jupiter.api.AfterEach
    public void tearDown() throws Exception {
    }
    
//    @BeforeAll
//    public static void setUpClass() {
//    }
//    
//    @AfterAll
//    public static void tearDownClass() {
//    }
//    
//    @BeforeEach
//    public void setUp() {
//    }
//    
//    @AfterEach
//    public void tearDown() {
//    }


    
    @Order(1) //Si no es defineix un ordre dels mètodes @test, ho fa en ordre alfabètic
    @Test
    public void testFalse() {
        System.out.println("1 - Executant test while false");
        ArrayList<Assignatura> assignatures = new ArrayList<Assignatura>();
        
        int comptador = While.LlistatAssignatures(assignatures);
       
        
        assertEquals(0, comptador, "El while no funciona");

    }
    
    @Order(2) //Si no es defineix un ordre dels mètodes @test, ho fa en ordre alfabètic
    @Test
    public void testDisponibleFalse() {
        System.out.println("2 - Executant test disponible false");
        ArrayList<Assignatura> assignatures = new ArrayList<Assignatura>();
        
        Assignatura ass = new Assignatura("M7",false);
        
        assignatures.add(ass);
        
        int comptador = While.LlistatAssignatures(assignatures);
        
        assertEquals(0, comptador, "El Disopnible es true");

    }
    
    @Order(3) //Si no es defineix un ordre dels mètodes @test, ho fa en ordre alfabètic
    @Test
    public void testDisponibleTrue() {
        System.out.println("3 - Executant test disponible true");
        ArrayList<Assignatura> assignatures = new ArrayList<Assignatura>();
        
        Assignatura ass = new Assignatura("M7",true);
        
        assignatures.add(ass);
        
        int comptador = While.LlistatAssignatures(assignatures);
        
        assertEquals(1, comptador, "Que el disponible es false");

    }
    

    
}
