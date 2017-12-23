using System.Collections.Generic;
using System.Data.Entity;


namespace EntityFramwork_FluentApi_and_DataAnotations
{
    public class DbInicilaizer:DropCreateDatabaseAlways<MyShopData>
    {
        protected override void Seed(MyShopData context)
        {
            using (MyShopData db = new MyShopData())
            {
                #region List customer

                //List<Customer> customers = new List<Customer>
                //{
                Customer c1 = new Customer {Id = 1, Name = "Иванов И.", Email = "ivan89@mail.ru"};
                Customer c2 = new Customer {Id = 2, Name = "Ведоров И.", Email = "fedIli9_65@list.ru"};
                Customer c3 = new Customer {Id = 3, Name = "Пошутько С.", Email = "79pohutkoSergei@yandex.ru"};
                Customer c4 = new Customer {Id = 4, Name = "Теруков Л.", Email = "terukovLeonid90@mail.ru"};
                Customer c5 = new Customer {Id = 5, Name = "Митрофанов В.", Email = "ValeriyMitrofanov99@gmail.com"};
                Customer c6 = new Customer {Id = 6, Name = "Петерту Д.", Email = "mimorDayDmitiry@yandex.ru"};
                Customer c7 = new Customer {Id = 7, Name = "Дживаров С.", Email = "DjivarSuleman@gmail.com"};
                Customer c8 = new Customer {Id = 8, Name = "Спиридонов К.", Email = "KostaRicaSpirMy@gmail.com"};
                Customer c9 = new Customer {Id = 9, Name = "Ушков Б.", Email = "DorisYhkov_1960@mail.ru"};
                Customer c10 = new Customer {Id = 10, Name = "Софронов Ф.", Email = "FidelFedorFeodorovich@gmail.com"};
                //};

                #endregion

                #region List product

                //List<Product> products = new List<Product>
                //{
                   Product p1 = new Product {Id = 1, Name = "Mouse", CompanyName = "Asus", PartNumber = "190-GP34sdPas0102", Coast = 990.99};
                Product p2 = new Product {Id = 2, Name = "Keyboard", CompanyName = "Logitech", PartNumber = "Log901-90-34KEYLEd", Coast = 2399.00};
                Product p3 = new Product {Id = 3, Name = "Mouse", CompanyName = "Logitech", PartNumber = "Log102-00-45MoSLED", Coast = 1234.00};
                Product p4 = new Product {Id = 4, Name = "Notebook", CompanyName = "Asus", PartNumber = "AsusRog-552JxVw", Coast = 59000.00};
                Product p5 = new Product {Id = 5, Name = "Hdd", CompanyName = "westernDigital", PartNumber = "WDBlack34-145_1Tb", Coast = 3990.00};
                Product p6 = new Product {Id = 6, Name = "Memory", CompanyName = "Kingston", PartNumber = "Kg_290-12-34-1666Mhz", Coast = 3990.00};
                Product p7 = new Product {Id = 7, Name = "Ssd", CompanyName = "Kingston", PartNumber = "Kg_256_MLC_9012", Coast = 5990.00};
                Product p8 = new Product {Id = 8, Name = "Hdd", CompanyName = "Toshiba", PartNumber = "TS_1TB_5900_newDis", Coast = 2590.00};
                Product p9 = new Product {Id = 9, Name = "VideoCard", CompanyName = "MSI", PartNumber = "MSI_1070TI_1493", Coast = 29000.00};
                Product p10 = new Product {Id = 10, Name = "VideoCard", CompanyName = "Asus", PartNumber = "Asus_1080Ti_1784", Coast = 51990.00};
                Product p11 = new Product {Id = 11, Name = "Motherboard", CompanyName = "Gigabyte", PartNumber = "Gig_H270_ProAtx", Coast = 9900.00};
                Product p12 = new Product {Id = 12, Name = "Motherboard", CompanyName = "Asus", PartNumber = "As_X299_ExpAtx", Coast = 30900.00};
                Product p13 = new Product {Id = 13, Name = "CPU", CompanyName = "Intel", PartNumber = "Intel_i7_7700k", Coast = 29000.00};
                Product p14 = new Product {Id = 14, Name = "CPU", CompanyName = "Intel", PartNumber = "Intel_i9_7900x", Coast = 70000.00};
                Product p15 = new Product {Id = 15, Name = "Ssd", CompanyName = "Intel", PartNumber = "Int_128_TLC", Coast = 2500.00};
            //};

                #endregion

                #region list orders

                //List<Order> orders = new List<Order>
                //{
            Order o1 = new Order {Id = 1, Customer = c9 };
                Order o2 = new Order {Id = 2, Customer = c3};
                Order o3 = new Order {Id = 3, Customer = c1};
                Order o4 = new Order {Id = 4, Customer = c10};
                Order o5 = new Order {Id = 5, Customer = c5};
                Order o6 = new Order {Id = 6, Customer = c2};
                Order o7 = new Order {Id = 7, Customer = c8};
                Order o8 = new Order {Id = 8, Customer = c1};
                Order o9 = new Order {Id = 9, Customer = c4};
                Order o10 = new Order {Id = 10, Customer = c7};
                Order o11 = new Order {Id = 11, Customer = c6};
                Order o12 = new Order {Id = 12, Customer = c1};
                Order o13 = new Order {Id = 13, Customer = c5};
                Order o14 = new Order {Id = 14, Customer = c3};
                Order o15 = new Order {Id = 15, Customer = c9};
                Order o16 = new Order {Id = 16, Customer = c8};
                Order o17 = new Order {Id = 17, Customer = c4};
                Order o18 = new Order {Id = 18, Customer = c4};
                Order o19 = new Order {Id = 19, Customer = c10};
                Order o20 = new Order {Id = 20, Customer = c7};
                Order o21 = new Order {Id = 21, Customer = c6};
                Order o22 = new Order {Id = 22, Customer = c1};
                Order o23 = new Order {Id = 23, Customer = c9};
                Order o24 = new Order {Id = 24, Customer = c5};
                Order o25 = new Order {Id = 25, Customer = c4};
                Order o26 = new Order {Id = 26, Customer = c4};
                Order o27 = new Order {Id = 27, Customer = c7};
                Order o28 = new Order {Id = 28, Customer = c2};
                Order o29 = new Order {Id = 29, Customer = c2};
                Order o30 = new Order {Id = 30, Customer = c8};
                //};

                #endregion

                #region add customer.Orders and customer.Products

                c1.Order.Add(o3);
                    c1.Product.Add(p4);
                c1.Order.Add(o8);
                    c1.Product.Add(p7);
                c1.Order.Add(o12);
                    c1.Product.Add(p1);
                c1.Order.Add(o22);
                    c1.Product.Add(p5);
                    c1.Product.Add(p6);

                c2.Order.Add(o6);
                    c2.Product.Add(p14);
                    c2.Product.Add(p12);
                c2.Order.Add(o28);
                    c2.Product.Add(p10);
                c2.Order.Add(o29);
                    c2.Product.Add(p7);
                    c2.Product.Add(p7);
                    c2.Product.Add(p6);
                    c2.Product.Add(p6);

                c3.Order.Add(o2);
                    c3.Product.Add(p2);
                c3.Order.Add(o14);
                    c3.Product.Add(p15);

                c4.Order.Add(o9);
                    c4.Product.Add(p13);
                c4.Order.Add(o17);
                    c4.Product.Add(p11);
                c4.Order.Add(o18);
                    c4.Product.Add(p6);
                c4.Order.Add(o25);
                    c4.Product.Add(p9);
                c4.Order.Add(o26);
                      c4.Product.Add(p2);
                    c4.Product.Add(p3);

                c5.Order.Add(o5);
                    c5.Product.Add(p13);
                    c5.Product.Add(p15);
                c5.Order.Add(o13);
                    c5.Product.Add(p6);
                    c5.Product.Add(p6);
                c5.Order.Add(o24);
                    c5.Product.Add(p10);

                c6.Order.Add(o11);
                    c6.Product.Add(p13);
                    c6.Product.Add(p11);
                    c6.Product.Add(p10);
                c6.Order.Add(o21);
                    c6.Product.Add(p6);
                    c6.Product.Add(p6);

                c7.Order.Add(o10);
                    c7.Product.Add(p4);
                c7.Order.Add(o20);
                    c7.Product.Add(p1);
                c7.Order.Add(o27);
                    c7.Product.Add(p15);

                c8.Order.Add(o7);
                    c8.Product.Add(p2);
                    c8.Product.Add(p3);
                c8.Order.Add(o16);
                    c8.Product.Add(p11);
                c8.Order.Add(o30);
                    c8.Product.Add(p2);

                c9.Order.Add(o1);
                    c9.Product.Add(p5);
                    c9.Product.Add(p7);
                c9.Order.Add(o15);
                    c9.Product.Add(p14);
                c9.Order.Add(o23);
                    c9.Product.Add(p1);

                c10.Order.Add(o4);
                    c10.Product.Add(p13);
                    c10.Product.Add(p8);
                c10.Order.Add(o19);
                    c10.Product.Add(p10);

                List<Customer> customers = new List<Customer>();
                customers.Add(c1);
                customers.Add(c2);
                customers.Add(c3);
                customers.Add(c4);
                customers.Add(c5);
                customers.Add(c6);
                customers.Add(c7);
                customers.Add(c8);
                customers.Add(c9);
                customers.Add(c10);
                #endregion

                #region add orders.Products

                o1.Product.Add(p5);
                o1.Product.Add(p7);

                o2.Product.Add(p2);

                o3.Product.Add(p4);

                o4.Product.Add(p13);
                o4.Product.Add(p8);

                o5.Product.Add(p13);
                o5.Product.Add(p15);

                o6.Product.Add(p14);
                o6.Product.Add(p12);

                o7.Product.Add(p2);
                o7.Product.Add(p3);

                o8.Product.Add(p7);

                o9.Product.Add(p13);

                o10.Product.Add(p4);

                o11.Product.Add(p13);
                o11.Product.Add(p11);
                o11.Product.Add(p10);

                o12.Product.Add(p1);

                o13.Product.Add(p6);
                o13.Product.Add(p6);

                o14.Product.Add(p15);

                o15.Product.Add(p14);

                o16.Product.Add(p11);

                o17.Product.Add(p11);

                o18.Product.Add(p6);

                o19.Product.Add(p10);

                o20.Product.Add(p1);

                o21.Product.Add(p6);
                o21.Product.Add(p6);

                o22.Product.Add(p5);
                o22.Product.Add(p6);

                o23.Product.Add(p1);

                o24.Product.Add(p10);

                o25.Product.Add(p9);

                o26.Product.Add(p2);
                o26.Product.Add(p3);

                o27.Product.Add(p15);

                o28.Product.Add(p10);

                o29.Product.Add(p7);
                o29.Product.Add(p7);
                o29.Product.Add(p6);
                o29.Product.Add(p6);

                o30.Product.Add(p2);

                List<Order> orders = new List<Order>
                { o1,o2,o3,o4,o5,o6,o7,o8,o9,o10,o11,o12,o13,o14,o15,o16,o17,o18,o19,o20,o21,o22,o23,o24,o25,o26,o27,o28,o29,o30 };

                #endregion

                #region add products.Customers and products.Orders

                p1.Customer.Add(c1);
                p1.Customer.Add(c7);
                p1.Customer.Add(c9);
                p1.Order.Add(o12);
                p1.Order.Add(o20);
                p1.Order.Add(o23);

                p2.Customer.Add(c3);
                p2.Customer.Add(c4);
                p2.Customer.Add(c8);
                p2.Customer.Add(c8);
                p2.Order.Add(o2);
                p2.Order.Add(o7);
                p2.Order.Add(o26);
                p2.Order.Add(o30);

                p3.Customer.Add(c4);
                p3.Customer.Add(c8);
                p3.Order.Add(o7);
                p3.Order.Add(o26);

                p4.Customer.Add(c1);
                p4.Customer.Add(c7);
                p4.Order.Add(o3);
                p4.Order.Add(o10);

                p5.Customer.Add(c1);
                p5.Customer.Add(c9);
                p5.Order.Add(o1);
                p5.Order.Add(o22);

                p6.Customer.Add(c1);
                p6.Customer.Add(c2);
                p6.Customer.Add(c2);
                p6.Customer.Add(c2);
                p6.Customer.Add(c4);
                p6.Customer.Add(c5);
                p6.Customer.Add(c5);
                p6.Customer.Add(c6);
                p6.Customer.Add(c6);
                p6.Order.Add(o13);
                p6.Order.Add(o13);
                p6.Order.Add(o18);
                p6.Order.Add(o21);
                p6.Order.Add(o21);
                p6.Order.Add(o22);
                p6.Order.Add(o29);
                p6.Order.Add(o29);

                p7.Customer.Add(c1);
                p7.Customer.Add(c2);
                p7.Customer.Add(c2);
                p7.Customer.Add(c9);
                p7.Order.Add(o1);
                p7.Order.Add(o8);
                p7.Order.Add(o29);
                p7.Order.Add(o29);

                p8.Customer.Add(c10);
                p8.Order.Add(o4);

                p9.Customer.Add(c4);
                p9.Order.Add(o25);

                p10.Customer.Add(c2);
                p10.Customer.Add(c5);
                p10.Customer.Add(c6);
                p10.Customer.Add(c10);
                p10.Order.Add(o11);
                p10.Order.Add(o19);
                p10.Order.Add(o24);
                p10.Order.Add(o28);

                p11.Customer.Add(c4);
                p11.Customer.Add(c6);
                p11.Customer.Add(c8);
                p11.Order.Add(o11);
                p11.Order.Add(o16);
                p11.Order.Add(o17);

                p12.Customer.Add(c2);
                p12.Order.Add(o6);

                p13.Customer.Add(c4);
                p13.Customer.Add(c5);
                p13.Customer.Add(c6);
                p13.Customer.Add(c10);
                p13.Order.Add(o4);
                p13.Order.Add(o5);
                p13.Order.Add(o9);
                p13.Order.Add(o11);


                p14.Customer.Add(c2);
                p14.Customer.Add(c9);
                p14.Order.Add(o6);
                p14.Order.Add(o15);

                p15.Customer.Add(c3);
                p15.Customer.Add(c5);
                p15.Customer.Add(c7);
                p15.Order.Add(o5);
                p15.Order.Add(o14);
                p15.Order.Add(o27);

                List<Product> products = new List<Product> {p1,p2,p3,p4,p5,p6,p7,p8,p9,p10,p11,p12,p13,p14,p15};
                #endregion

                db.Products.AddRange(products);
                db.Customers.AddRange(customers);
                db.Orders.AddRange(orders);
                db.SaveChanges();
            };
        }
    }
}
