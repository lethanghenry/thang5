using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
   
        static Product findProduct (List<Product> listProduct, string nameProduct)
        {
            foreach (Product p in listProduct)
            {
                if (p.name == nameProduct)
                {
                    return p;
                }
                

            }
            return new Product();
        }

        static List<Product> findCategoryId(List<Product> listProduct, int categoryId)
        {
            List<Product> li2=new List<Product>();
            foreach (Product p in listProduct)
            {
                if (p.categoryId == categoryId)
                {
                    li2.Add(p);
                   
                }


            }
            return li2;
        }
        static List<Product> findPrice(List<Product> listProduct, int price)
        {
            List<Product> li2 = new List<Product>();
            foreach (Product p in listProduct)
            {
                if (p.price < price)
                {
                    li2.Add(p);

                }


            }
            return li2;
        }
        static List<Product> sortByPrice(List<Product> listProduct)
        {
            int n = listProduct.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (listProduct[j].price < listProduct[j + 1].price)
                    {
                        Product a = new Product();
                        a = listProduct[j];
                        listProduct[j] = listProduct[j + 1];
                        listProduct[j + 1] = a;
                    }
                }
            }
            return listProduct;
        }

        static List<Product> sortByName(List<Product> listProduct)
        {
            int n = listProduct.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (String.Compare(listProduct[j - 1].name,listProduct[j].name)<0)
                    {
                        Product a = new Product();
                        a = listProduct[j - 1];
                        listProduct[j - 1] = listProduct[j];
                        listProduct[j] = a;
                    }
                }
               
            }
            return listProduct;
        }

        static List<Category> sortByNameCatefory(List<Category> listCategory)
        {
            int n = listCategory.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (String.Compare(listCategory[j - 1].name, listCategory[j].name) < 0)
                    {
                        Category a = new Category();
                        a = listCategory[j - 1];
                        listCategory[j - 1] = listCategory[j];
                        listCategory[j] = a;
                    }
                }

            }
            return listCategory;
        }
        static List<Product> sortByCategoryName(List<Product> listP,List<Category> listC)
        {
            List<Category> list5 = sortByNameCatefory(listC);

          
            foreach (Product p in listP)
            {
                foreach (Category c in list5)
                {
                    c.id =p.categoryId;
                }
            }
            return listP;
        }

        static void Main(string[] args)
        {

            List<Product> listProduct = new List<Product>();
              Product product1 = new Product("CPU",750,10,1);
              Product product2 = new Product("RAM", 50, 2, 2);
              Product product3 = new Product("HDD", 70, 1, 2);
              Product product4 = new Product("Main", 400, 3, 1);
              Product product5 = new Product("Keyboard", 30, 8, 4);
              Product product6 = new Product("Mouse", 25, 50, 4);
              Product product7 = new Product("VGA", 60, 35, 3);
              Product product8 = new Product("Monitor", 120, 28, 2);
              Product product9 = new Product("Case", 120, 28, 5);
         
              listProduct.Add(product1);
              listProduct.Add(product2);
              listProduct.Add(product3);
              listProduct.Add(product4);
              listProduct.Add(product5);
              listProduct.Add(product6);
              listProduct.Add(product7);
              listProduct.Add(product8);
              listProduct.Add(product9);
            
            

            List<Category> listCategory=new List<Category>();
            Category category1 = new Category(1, "Computer");
            Category category2 = new Category(2, "Memory");
            Category category3 = new Category(3, "Card");
            Category category4 = new Category(4, "Acsesory");
            
            listCategory.Add(category1);
            listCategory.Add(category2);
            listCategory.Add(category3);
            listCategory.Add(category4);
            
      
            Console.WriteLine("Danh sách products");
            foreach(Product p in listProduct)
            {              
                Console.WriteLine(p);
            }
            

            // nhập tên nameProduct để in ra product có name
           
                        Console.WriteLine("Nhập tên Product");
                        string nameProduct = Console.ReadLine();



          Console.WriteLine(findProduct(listProduct, nameProduct));

            //nhập categoryID

             Console.WriteLine("Nhập tên categoryId");
             int cate = int.Parse(Console.ReadLine());
             List<Product> list = findCategoryId(listProduct, cate);
             
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }

            //nhập price
            Console.WriteLine("Nhập tên price");
            int price = int.Parse(Console.ReadLine());
            List<Product> list2 = findPrice(listProduct, price);
            foreach(Product p in list2)
            {
                Console.WriteLine(p);
            }


            //sắp xếp
            // theo price
            Console.WriteLine("danh sách sau khi sắp xếp theo price");
            List<Product> list3 = sortByPrice(listProduct);
            foreach(Product p in list3)
            {
                Console.WriteLine(p);
            }


            //theo name
            Console.WriteLine("danh sách sau khi sắp xếp theo name");
            List<Product> list4 = sortByName(listProduct);
            foreach (Product p in list4)
            {
                Console.WriteLine(p);
            }


            Console.WriteLine("sắp xêp theo category name");
            List<Product> list5 = sortByCategoryName(listProduct, listCategory);
            foreach (Product p in list5)
            {
                Console.WriteLine(p);
            }


                Console.ReadKey();
          



        }
    }
       
}
