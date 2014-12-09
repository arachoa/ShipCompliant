﻿using System.IO;
using System.Security.Cryptography;
using Golem.ShipCompliant.PublicPro.PageObjects;
using MbUnit.Framework;
using ProtoTest.Golem.Core;
using ProtoTest.Golem.WebDriver;

namespace Golem.ShipCompliant.PublicPro.Tests
{
    public class PublicPROApplicationTest : WebDriverTestBase
    {
        //Here's a line
       private string publicproUrl = Config.GetConfigValue("PublicProUrl", "http://publicpro-staging.shipcompliant.com");
       private string permitnumber = Config.GetConfigValue("PermitNumber", "NY-I-15204");
       private string permittext = Config.GetConfigValue("PermitText", "NY-I-15204 - PERNOD RICARD USA, LLC");
       private string welcometext = Config.GetConfigValue("WelcomeText", "Welcome PERNOD RICARD USA, LLC!");
       private string colanumber = Config.GetConfigValue("COLANumber", "13233001000111");
       private string colatext = Config.GetConfigValue("ColaText", "PERRIER JOUET CHAMPAGNE (13233001000111)");
       private string firstname = Config.GetConfigValue("FirstName", "proto");
       private string lastname = Config.GetConfigValue("LastName", "test");
       private string password = Config.GetConfigValue("Password", "Pa33word");
       private string phonenumber = Config.GetConfigValue("PhoneNumber", "303-777-4545");
       private string address1 = Config.GetConfigValue("Address1", "129 Main St");
       private string address2 = Config.GetConfigValue("Address2", "10");
       private string city = Config.GetConfigValue("City", "Longmont");
       private string state = Config.GetConfigValue("State", "CO");
       private string zip = Config.GetConfigValue("Zip", "80501");
       private string stateoption = Config.GetConfigValue("StateOption", "Kansas");
       private string licensenumber = Config.GetConfigValue("LicenseNumber", "19001200280");
       private string productdetailsheader = Config.GetConfigValue("ProductDetailsHeader", "Tell us about your products!");
       private string vintageyear1 = Config.GetConfigValue("VintageYear1", "2010");
       private string bottlesize1 = Config.GetConfigValue("BottleSize1", "750 mL");
       private string abv1 = Config.GetConfigValue("ABV1", "14.0");
       private string bottlespercase1 = Config.GetConfigValue("BottlesPerCase1", "24");
       private string vintageyear2 = Config.GetConfigValue("VintageYear2", "2011");
       private string bottlesize2 = Config.GetConfigValue("BottleSize2", "1 L");
       private string abv2 = Config.GetConfigValue("ABV2", "13.5");
       private string bottlespercase2 = Config.GetConfigValue("BottlesPerCase2", "18");
       private string distributorlicense = Config.GetConfigValue("DistributorLicense", "18004018502");
       private string distributorname = Config.GetConfigValue("DistributorName", "EAGLE BEVERAGE");
       private string bottlingfilepath = Config.GetConfigValue("BottlingFilePath", "C:\\Users\\Ara\\Desktop\\Test Bottling Letter1.pdf");
       private string authorizationfilepath = Config.GetConfigValue("Authorizationfilepath", "C:\\Users\\Ara\\Desktop\\Test Brand Authorization Letter1.pdf");
       private string appointmentfilepath = Config.GetConfigValue("Appointmentfilepath", "C:\\Users\\Ara\\Desktop\\Test Appointment Letter1.pdf");
       private string testcomment = Config.GetConfigValue("TestComment", "QA Test Comment for State Administrator");
       private string bottlingdoc = Config.GetConfigValue("BottlingDoc", "Test Bottling Letter1.pdf");
       private string authorizationdoc = Config.GetConfigValue("AuthorizationDoc", "Test Brand Authorization Letter1.pdf");
       private string appointmentdoc = Config.GetConfigValue("AppointmentDoc", "Test Appointment Letter1.pdf");
       private string creditcardnum = Config.GetConfigValue("CreditCardNum", "4111111111111111");
       private string cvvnumber = Config.GetConfigValue("CVVNumber", "123");
       private string creditmonth = Config.GetConfigValue("CreditMonth", "12");
       




        [Test]
       public void CreatePublicProRegistration()
       {

           OpenPage<LandingPage>(publicproUrl)
               .ClickBeginRegistrationButton()
               .VerifySelectCOLAHighlighted()
               .TypePermitNum(permitnumber)
               .SelectDropdownOption(permittext)
               .VerifyWelcomeLicenseMessage(welcometext)
               .TypeCOLANum(colanumber)
               .SelectCOLADropdownOption(colatext)
               .VerifyLabelCOLANum(colanumber)
               .SelectTheLable(colanumber)
               .VerifySelectLabelButton()
               .VerifyColanumOverlay(colanumber)
               .ClickSelectLabelButton()
               .SelectCreateNewTab()
               .CreateNewEmailAddress(firstname, lastname)
               .EnterNewAccoutInformation(firstname, lastname, password, phonenumber,
               address1, address2, city, state, zip)
               .SelectCreateMyAccoutBtn()
               .SelectAStateBtn(stateoption)
               .EnterLicenseNumber(licensenumber)
               .SelectLicenseNumOption(licensenumber)
               .VerifyLicenseNumber(licensenumber)

               //Product Entry
               .SelectNewBrandRegistration()
               .VerifyProductDetailsHighlighted()
               .VerifyProductDetailsHeader(productdetailsheader)
               .EnterProductInformation(vintageyear1, bottlesize1, abv1, bottlespercase1)
               .SelectAddAnotherProduct()
               .VerifyProductDisplayed(bottlesize1)
               .EnterProductInformation(vintageyear2, bottlesize2, abv2, bottlespercase2)
               .VerifyLabelImages()
               .SelectContinueButton()

               //Distributors
               .VerifySelectDistributorsHighlighted()
               .SelectAddNewDistributors()
               .TypeDistributorNum(distributorlicense)
               .SelectDistributorOption(distributorlicense)
               .VerifyDistributorName(distributorname)
               .SelectAllStateLink()
               .VerifyFirstLastStateChecked()
               .SelectSaveDistributorButton()
               .ClickEnabledDistributorBtn()
               .VerifyDistributorBtnDisabled()
               .SelectContinueDocumentsBtn()
               .ClickDisabledDistributorBtn()
               .ReSelectContinueDocumentsBtn()
               .VerifyOverlayTitle()
               .VerifyBrandOwnerRadioButtonSelected()
               .SelectRadioButtons()

               //Supporting Documents
               .VerifySupportingDocumentsHighlighted()
               .UploadBottlingLetter(bottlingfilepath)
               .VerifyBottlingLetter(bottlingdoc)
               .UploadAuthorizationLetter(authorizationfilepath)
               .VerifyAuthorizationLetter(authorizationdoc)
               .UploadAppointmentLetter(appointmentfilepath)
               .VerifyAppointmentLetter(appointmentdoc)
               .TypeComments(testcomment)
               .SelectContinueReviewButton()
               .EnterSigniture()
               .SelectContinueButton()
               .VerifyReviewSlider()
               .VerifyStateRegistration()
               .VerifyFeesSummary()
               .VerifyTotalFees()
               .VerifyCreditCardName(firstname, lastname)
              // .TypeCreditCardInformation(creditcardnum, cvvnumber, creditmonth, zip)
               .VerifyApplicantDetails(address1, address2, city, state, zip)
               .VerifyDocuments(bottlingdoc, authorizationdoc, appointmentdoc)
               .VerifyDistributorName()
               .VerifyComments()
               .SelectSubmitButton()
               .VerifySubmitMessage();

              

               

         
               
               
                

       }



    }
}
