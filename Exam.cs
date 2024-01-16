using System;

abstract class Product {
    public string ProductId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Producer { get; set; }

    public Product(string productId, string name, double price, string producer) {
        ProductId = productId;
        Name = name;
        Price = price;
        Producer = producer;
    }

    public abstract double ComputeTax();
}

class Book : Product {
    public Book(string productId, string name, double price, string producer) : base(productId, name, price, producer) { }

    public override double ComputeTax() {
        return Price * 0.08;
    }
}

class MobilePhone : Product {
    public MobilePhone(string productId, string name, double price, string producer) : base(productId, name, price, producer) { }

    public override double ComputeTax() {
        return Price * 0.10;
    }
}

class Exam {
    static void Main(string[] args) {
        Product[] products = new Product[6];
        // Initialize the array with three books and three mobile phones
        // For simplicity, let's assume the price of each book is $20 and each mobile phone is $200
        for (int i = 0; i < 3; i++) {
            products[i] = new Book("book" + i, "Book" + i, 20, "Producer" + i);
            products[i + 3] = new MobilePhone("phone" + i, "Phone" + i, 200, "Producer" + i);
        }

        double totalTax = 0;
        foreach (Product product in products) {
            totalTax += product.ComputeTax();
        }

        Console.WriteLine("Total tax of books and mobile phones is: " + totalTax);
    }
}
