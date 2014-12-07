using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;
using Castle.Core.Resource;
using Gallio.Framework.Data;
using OpenQA.Selenium;
using ProtoTest.Golem.Core;
using ProtoTest.Golem.WebDriver;
using ProtoTest.Golem.WebDriver.Elements.Types;


namespace Golem.ShipCompliant.PublicPro.PageObjects
{
    public class SupportingDocuments : BasePageObject
    {
        Element supportingDocumentsSlider = new Element("SupportingDocumentsSlider", By.XPath("//div[@class='step active']"));
        Button bottlingLetterUpload = new Button(By.XPath("//div[@data-documenttypename='Bottling Letter']"));
        Button authorizationLetterUpload = new Button(By.XPath("//div[@data-documenttypename='Brand Owner Authorization Letter']"));
        Button appointmentLetterUpload = new Button(By.XPath("//div[@data-documenttypename='Distributor Appointment Letter - EAGLE BEVERAGE']"));
        //string PDFPathOne = Config.GetConfigValue("BottlingLetterPDF", Directory.GetCurrentDirectory() + @".\\DataSource\\Test Bottling Letter1.pdf");
        //string PDFPathTwo = Config.GetConfigValue("BrandAuthorizationPDF", Directory.GetCurrentDirectory() + @".\\DataSource\\Test Brand Authorization Letter1.pdf");
        //string PDFPathThree = Config.GetConfigValue("AppointmentPDF", Directory.GetCurrentDirectory() + @".\\DataSource\\Test Appointment Letter1.pdf");
        Text bottlingLetterFileName = new Text(By.XPath("//div[@data-documenttypename='Bottling Letter']"));
        Text authorizationLetterFileName = new Text(By.XPath("//div[@data-documenttypename='Brand Owner Authorization Letter']"));
        Text appointmentLetterFileName = new Text(By.XPath("//div[@data-documenttypename='Distributor Appointment Letter']"));
        Button browseButton = new Button(By.XPath("//input[@name='file']"));
        Button saveDocumentButton = new Button(By.XPath("//button[@class='button button-blue' and contains(.,'Save document')]"));
        Element comments = new Element("Comments", By.XPath("//textarea[@id='comments']"));
        Button continueReview = new Button(By.XPath("//a[@class='button continue']"));
           

        public override void WaitForElements()
        {

        }

        public SupportingDocuments VerifySupportingDocumentsHighlighted()
        {
            supportingDocumentsSlider.Verify().Visible();
            supportingDocumentsSlider.Highlight();

            return this;
        }

        public SupportingDocuments UploadBottlingLetter(string bottlingfilepath)
        {
            bottlingLetterUpload.Click();
            browseButton.SendKeys(bottlingfilepath);
            saveDocumentButton.Click();

            return new SupportingDocuments();
        }

        public SupportingDocuments VerifyBottlingLetter(string bottlingdoc)
        {
            bottlingLetterFileName.Verify().Text(bottlingdoc);

            return this;
        }

        public SupportingDocuments UploadAuthorizationLetter(string authorizationfilepath)
        {
            authorizationLetterUpload.Click();
            browseButton.SendKeys(authorizationfilepath);
            saveDocumentButton.Click();

            return new SupportingDocuments();
        }

        public SupportingDocuments VerifyAuthorizationLetter(string authorizationdoc)
        {
            authorizationLetterFileName.Verify().Text(authorizationdoc);

            return this;
        }

        public SupportingDocuments UploadAppointmentLetter(string appointmentfilepath)
        {
            appointmentLetterUpload.Click();
            browseButton.SendKeys(appointmentfilepath);
            saveDocumentButton.Click();

            return new SupportingDocuments();
        }

        public SupportingDocuments VerifyAppointmentLetter(string appointmentdoc)
        {
            appointmentLetterFileName.Verify().Text(appointmentdoc);

            return this;
        }

        public SupportingDocuments TypeComments(string testcomment)
        {
            comments.WaitUntil().Visible().Text = testcomment;
            //comments.Text = testcomment;

            return this;
        }

        public eSignatureOverlay SelectContinueReviewButton()
        {
            continueReview.Click();

            return new eSignatureOverlay();
        }


    }
}
