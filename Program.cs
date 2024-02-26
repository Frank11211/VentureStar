
using System;
using System.Collections.Generic;  

namespace Test{
    
    class Product {

        // Get Set Method
        public string Name {get; set;}
        public decimal Price {get; set;}
        public int Category {get; set;}
    

        static void Main(string[] args){

            int totalProductNum = 2; // Total Product Length
        
            List<Product> Products = new List<Product>();  // store a lits of Product object
            
            for(int i = 0; i < totalProductNum ; i++){   // Add product item into Produts list
                Product item = new Product();

                Console.Write("Product Name: ");  
                item.Name = Console.ReadLine();
                
                Console.Write("Product Price: ");
                string temp = Console.ReadLine();
                item.Price = Convert.ToDecimal(temp);

                Console.Write("Product Category: ");
                string temp2 = Console.ReadLine();
                item.Category = Convert.ToInt32(temp2);
                
                // Whitespace
                Console.WriteLine("");

                Products.Add(item); 
            }

            // Update Product Name "Item2" -> "New Item2" 
            void UpdateItemName(){
                foreach(Product item in Products ){
                    if(item.Name == "Item2"){
                        item.Name = "New Item 2"; 
                    }
                }
            }

            // Display Original Data
            Console.WriteLine("");
            Console.WriteLine("------ All Product Item----------");
            foreach( Product obj in Products){
                Console.WriteLine($"name:{obj.Name} , price:{obj.Price}, category:{obj.Category}");
            }

            UpdateItemName();

            //Display Updated Data
            Console.WriteLine("");
            Console.WriteLine("------ Updated Product Item Name----------");
            foreach( Product obj in Products){
                Console.WriteLine($"name:{obj.Name} , price:{obj.Price}, category:{obj.Category}");
            }


        }
        
    }
    
}

