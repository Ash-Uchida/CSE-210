using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("This is the Encapsulation with Online Ordering\n");

        // define a customer and their address
        Address add1 = new Address("67 Cherry ave","Mesa","AZ","USA");
        Customer cus1 = new Customer("Mary Lou", add1);
        Order ord1 = new Order(cus1);

        Address add2 = new Address("123 Sesame Street","New York City","NY","USA");
        Customer cus2 = new Customer("Big Bird", add2);
        Order ord2 = new Order(cus2);

        Address add3 = new Address("44 Tim Jacobds drive","Toronto","ON","Canada");
        Customer cus3 = new Customer("Your Mom", add3);
        Order ord3 = new Order(cus3);

        // define a list of products
        Product pro1 = new Product("Cherry dove soap","dSp23",9.99);
        Product pro2 = new Product("Hibiscus shampoo","hbS0043",15.99);
        Product pro3 = new Product("Vanilla Shea butter lotion","vsbu83",18.99);
        Product pro4 = new Product("Pomagranite Deodarant","POd067",8.99);
        Product pro5 = new Product("Lemon Lime Conditioner","LLco98",15.99);

        // add the products to the customers order
        ord1.AddProduct(pro1, 2);
        ord1.AddProduct(pro3, 1);
        ord1.AddProduct(pro4, 3);

        ord2.AddProduct(pro2, 1);
        ord2.AddProduct(pro5,1);
        ord2.AddProduct(pro3, 2);
        ord2.AddProduct(pro4, 3);

        ord3.AddProduct(pro1, 5);
        ord3.AddProduct(pro5, 2);

        List<Order> orders = new List<Order> { ord1, ord2, ord3 };

        foreach(Order o in orders)
        {
            Console.WriteLine($"---------------------------------------\n{o.PackingLabel()}---------------------------------------");
            Console.WriteLine($"---------------------------------------\n Shipping Label\n\n{o.ShippingLabel()}\n---------------------------------------");
            Console.WriteLine($"\nTotal Amount: {o.Total()}  --  {o.GetName()}\n\n\n");
        }

        
    }
}

