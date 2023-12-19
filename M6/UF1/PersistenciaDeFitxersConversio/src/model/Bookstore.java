/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package model;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author xavi
 */
public class Bookstore {
    
    private List<Book> bookstore;

    public Bookstore getBookstore() {
        return (Bookstore)bookstore;
    }

    public void setBookstore(List<Book> bookstore) {
        this.bookstore = bookstore;
    }
    
    public void add(Book book) {
		if (this.bookstore == null) {
			this.bookstore = new ArrayList<Book>();
		}
		this.bookstore.add(book);
	}

    @Override
    public String toString() {
        String s = "";
		for (Book bo : bookstore)
			s = s + bo.toString() + "\n";
		return s;
    }
    
}
