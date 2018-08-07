package com.payrollhr.rest_api.model;

import com.payrollhr.rest_api.data_repository.ModelBase;

import java.time.Month;
import java.util.Date;

public class Company   extends ModelBase //
{
    //Company identification
    public String companyName;
    public String vatNumber;
    public String businessActivity;
    public Date financialYearStartDate;
    public Date financialYearEndDate;
    public Month conversionMonth;
    public String baseCurrency;

    //Accounting Setting up
    public String bankName;
    public String accountNo;
    public String bankAddress;
    public String phoneNo;
    public String faxNo;
    public String contactName;
    public String swiftCode_BIC;
    public String ibanCode;
    public String bankCode;
    public String branchCode;

    //Banking Details
    public String bankName_BankingDetails;
    public String accountNo_BankingDetails;
    public String accountName_BankingDetails;
    public String bankAddress_BankingDetails;
    public String phoneNo_BankingDetails;
    public String faxNo_BankingDetails;
    public String contactName_BankingDetails;
    public String swiftCode_BIC_BankingDetails;
    public String ibanCode_BankingDetails;
    public String bankCode_BankingDetails;
    public String branchCode_BankingDetails;

    //Contact Details
    public String addressNo_Contact_Details;
    public String address_Street_Contact_Details;
    public String addressArea_Sangkat_Contact_Details;
    public String address_Khan_Contact_Details;
    public String town_City_Contact_Details;
    public String poBox_Contact_Details;
    public String phoneNo_Contact_Details;
    public String faxNo_Contact_Details;
    public String email_Contact_Details;

}