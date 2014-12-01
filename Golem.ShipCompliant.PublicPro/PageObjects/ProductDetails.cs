using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ProtoTest.Golem.WebDriver;
using ProtoTest.Golem.WebDriver.Elements.Types;
using System.Threading;

namespace Golem.ShipCompliant.PublicPro.PageObjects
{
    public class ProductDetails : BasePageObject
    {
        Element productDetailsSlider = new Element("ProductDetailsSlider", By.XPath("//div[@class='step active']/a[contains(Product, Details)]"));
        public Dropdown vintageDropdown = new Dropdown(By.XPath("//select[@id='productVintage']"));
        public Dropdown bottleSizeDropdown = new Dropdown(By.XPath("//select[@id='productBottleName']"));
        Element abvTextBox = new Element("ABVTextbox", By.XPath("//input[@id='productAlcoholByVolume']"));
        Element bottlesPerCaseTextBox = new Element("BottlesPerCaseTextbox", By.XPath("//input[@name='product.NonWineItemsPerCase']"));
        Link addAnotherProduct = new Link(By.XPath("//a[@id='add-another-product']"));
        Element productItemName = new Element("ProductItemName", By.XPath("//div[@class='review-item span product clearfix']//strong[contains(.,'Product 1')]"));
        Element frontImage = new Element("FrontImage", By.XPath("//div[@class='labelIcon']/*[text()='Front']"));
        Element backImage = new Element("BackImage", By.XPath("//div[@class='labelIcon']/*[text()='Back']"));
        Element neckImage = new Element("NeckImage", By.XPath("//div[@class='labelIcon']/*[text()='Neck']"));
        Element continueButton = new Element("ContinueButton", By.XPath("//a[@id='continue']"));
        
        
        public Element productSize(string text)
        {
            return new Element("ProductSize", By.XPath("//div[@class='review-item span product clearfix']//span[@class='c3' and contains(.,'" + text + "')]"));
        }
            
        
        
        public Element productDetailsHeader(string text)
        {
            return new Element("ProductDetailsHeader", By.XPath("//h2[contains(.,'" + text + "')]"));
        }
        
        public override void WaitForElements()
        {

        }

        public ProductDetails VerifyProductDetailsHighlighted()
        {
            productDetailsSlider.Verify().Visible();
            productDetailsSlider.Highlight();

            return this;
        }

        public ProductDetails VerifyProductDetailsHeader(string text)
        {
            productDetailsHeader(text).Verify().Visible();

            return this;
        }

        public ProductDetails EnterProductInformation(string vintageyear1, string bottlesize1, string abv1, string bottlespercase1)
        {
            //stateDropdown.SelectOption(state);
            vintageDropdown.SelectOption(vintageyear1);
            bottleSizeDropdown.SelectOption(bottlesize1);
            abvTextBox.Text = abv1;
            bottlesPerCaseTextBox.Text = bottlespercase1;

            return this;
        }

        public ProductDetails SelectAddAnotherProduct()
        {
            addAnotherProduct.Click();

            return new ProductDetails();
        }

        public ProductDetails VerifyProductDisplayed(string text)
        {
            productItemName.Verify().Visible();
            productItemName.Highlight();
            productSize(text).Verify().Visible();
            productSize(text).Highlight();

            return this;
        }

        public ProductDetails VerifyLabelImages()
        {
            frontImage.Verify().Visible();
            backImage.Verify().Visible();
            neckImage.Verify().Visible();

            return this;
        }

        public SelectDistributors SelectContinueButton()
        {
            continueButton.Click();

            return new SelectDistributors();
        }




    }






}
