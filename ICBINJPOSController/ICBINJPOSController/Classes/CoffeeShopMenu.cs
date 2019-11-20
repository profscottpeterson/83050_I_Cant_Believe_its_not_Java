using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICBINJPOSController
{
    public class CoffeeShopMenu
    {
        private List<Item> icbinjMenu;

        public List<Item> IcbinjMenu
        {
            get { return icbinjMenu; }
            set { icbinjMenu = value; }
        }

        public CoffeeShopMenu()
        {
            try
            {
                List<Item> tempList = new List<Item>();
                Item tempItem;

                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader openFile = new StreamReader("DrinkMenu.txt"))
                {
                    // Holds each line read from file.
                    string line;

                    // How many times the line should be split.
                    int numOfSplits = 4;

                    // Holds each segment of the line.
                    string[] lineSegment = new string[numOfSplits];

                    // Temporary variable, holds item description.
                    string tempDescription = "";

                    // How many prices are in the file for each item.
                    int numOfPrices = 3;

                    // Temporary variable, holds an array of price options for each menu item.
                    double[] tempPriceOptions = new double[numOfPrices];

                    // Holds the parsed from string price.
                    double parsedPrice;
                   
                    // Read a line of text from file if not empty and not end of stream.
                    while ((line = openFile.ReadLine()) != null && !openFile.EndOfStream) 
                        {
                            // Split the line into an array. Uses a delimeter (,) char to split.
                            lineSegment = line.Split(',');

                            // Hold the price array index, reset to zero with each new line item.
                            int priceArrayIndex = 0;

                            // First array value is Item.description
                            tempDescription = lineSegment[0];

                            // Assign array values to the temp. Item object variable: description and priceOptions.
                            for (int segmentNum = 1; segmentNum < numOfSplits; segmentNum++)
                            {
                                // Line segment array indices 1-3 are Item.PriceOption array values.
                                if (double.TryParse(lineSegment[segmentNum], out parsedPrice))
                                {
                                    tempPriceOptions[priceArrayIndex] = parsedPrice;
                                    priceArrayIndex++;
                                }
                                else
                                {
                                    System.Windows.Forms.MessageBox.Show("Prices corrupted, seek administrator assistance.");
                                }
                            }
                            // Create a new Item with description and price option array.
                            tempItem = new Item(tempDescription, tempPriceOptions);

                            // Add item to temp list.
                            tempList.Add(tempItem);
                       
                    }
                    // Initialize Coffee Shop Menu list, with temp list.
                    this.IcbinjMenu = tempList;
                }
            }
            catch (IOException)
            {
                System.Windows.Forms.MessageBox.Show("Menu file not found, seek administrator assistance.");
            }
            catch (IndexOutOfRangeException)
            {
                System.Windows.Forms.MessageBox.Show("Menu file corrupted, seek administrator assistance.");
            }
        }
    }
}
