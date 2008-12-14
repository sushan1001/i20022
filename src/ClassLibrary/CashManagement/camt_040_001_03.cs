
//                                      ______    ____  
//                                     |____  | "|__  | 
//                                      _   | |     | | 
//                                     | |  | |   __| | 
//                                     |_|  |_|  |_____| 
//
//  --------------------------------------------------- 
// |     _   ____     ___     ___    ____    ____      |
// |    (_) |___ \   / _ \   / _ \  |___ \  |___ \     |
// |    | |   __) | | | | | | | | |   __) |   __) |    |
// |    | |  / __/  | |_| | | |_| |  / __/   / __/     |
// |    |_| |_____|  \___/   \___/  |_____| |_____|    |
// |                                                   |
// |    AN ISO 20022 OPEN-SOURCE .NET CLASS LIBRARY    |
// |            FOR MESSAGING APPLICATIONS             |
// |                                                   |
// |        Copyright (C) 2008 Mauricio Leventer       |
// |                mleventer@i20022.com               |
// |                                                   |
//  ---------------------------------------------------
//
// L I C E N S E                                         
//                                                       
// This program is free software; you can redistribute it
// and/or modify it under the terms of the GNU General   
// Public License as published by the Free Software      
// Foundation; either version 2 of the License, or (at   
// your option) any later version.                       
//                                                       
// This program is distributed in the hope that it will  
// be useful, but WITHOUT ANY WARRANTY; without even the 
// implied warranty of MERCHANTABILITY or FITNESS FOR A  
// PARTICULAR PURPOSE. See the GNU General Public License
// for more details.                                     
//                                                       
// You should have received a copy of the GNU General    
// Public License along with this program; if not, write 
// to the Free Software Foundation, Inc.,                
// 59 Temple Place, Suite 330, Boston, MA                
// 02111-1307 USA.                                       
//                                                       
//
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Serialization;



namespace i20022.camt04000103
{



    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id camt.040.001.03 name FundEstimatedCashForecastReportV03 from Cash Management business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>FndEstmtdCshFcstRptV03</b> (Fund Estimated Cash Forecast Report V03) of type FundEstimatedCashForecastReportV03.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public FundEstimatedCashForecastReportV03 FndEstmtdCshFcstRptV03;
    }

    /// <summary>
    /// Class <b>FundEstimatedCashForecastReportV03</b> (Fund Estimated Cash Forecast Report V03).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class FundEstimatedCashForecastReportV03
    {

        /// <summary>
        /// Element <b>MsgId</b> (Message Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public MessageIdentification1 MsgId;

        /// <summary>
        /// Element <b>PoolRef</b> (Pool Reference) of type AdditionalReference3.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public AdditionalReference3 PoolRef;

        /// <summary>
        /// Element <b>PrvsRef</b> (Previous Reference) of type array of AdditionalReference3.
        /// </summary>
        [XmlElementAttribute( "PrvsRef", Order = 2 )]
        public AdditionalReference3[] PrvsRef;

        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type array of AdditionalReference3.
        /// </summary>
        [XmlElementAttribute( "RltdRef", Order = 3 )]
        public AdditionalReference3[] RltdRef;

        /// <summary>
        /// Element <b>MsgPgntn</b> (Message Pagination) of type Pagination.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public Pagination MsgPgntn;

        /// <summary>
        /// Element <b>EstmtdFndCshFcstDtls</b> (Estimated Fund Cash Forecast Details) of type array of EstimatedFundCashForecast3.
        /// </summary>
        [XmlElementAttribute( "EstmtdFndCshFcstDtls", Order = 5 )]
        public EstimatedFundCashForecast3[] EstmtdFndCshFcstDtls;

        /// <summary>
        /// Element <b>CnsltdNetCshFcst</b> (Cnsltd Net Cash Forecast) of type NetCashForecast3.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public NetCashForecast3 CnsltdNetCshFcst;

        /// <summary>
        /// Element <b>Xtnsn</b> (Extension) of type array of Extension1.
        /// </summary>
        [XmlElementAttribute( "Xtnsn", Order = 7 )]
        public Extension1[] Xtnsn;
    }

    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class MessageIdentification1
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public System.DateTime CreDtTm;
    }

    /// <summary>
    /// Class <b>Extension1</b> (Extension 1).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class Extension1
    {

        /// <summary>
        /// Element <b>PlcAndNm</b> (Place And Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string PlcAndNm;

        /// <summary>
        /// Element <b>Txt</b> (Txt) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Txt;
    }

    /// <summary>
    /// Class <b>NetCashForecast3</b> (Net Cash Forecast 3).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class NetCashForecast3
    {

        /// <summary>
        /// Element <b>NetAmt</b> (Net Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ActiveOrHistoricCurrencyAndAmount NetAmt;

        /// <summary>
        /// Element <b>NetUnitsNb</b> (Net Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public FinancialInstrumentQuantity1 NetUnitsNb;

        /// <summary>
        /// Element <b>FlowDrctn</b> (Flow Direction) of type FlowDirectionType1Code.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public FlowDirectionType1Code FlowDrctn;
    }

    /// <summary>
    /// Class <b>ActiveOrHistoricCurrencyAndAmount</b> (Active Or Historic Currency And Amount).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class ActiveOrHistoricCurrencyAndAmount
    {

        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Ccy;

        /// <summary>
        /// Element <b>Value</b> (Value) of type decimal.
        /// </summary>
        [XmlTextAttribute()]
        public decimal Value;
    }

    /// <summary>
    /// Class <b>FinancialInstrumentQuantity1</b> (Financial Instrument Quantity 1).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class FinancialInstrumentQuantity1
    {

        /// <summary>
        /// Element <b>Unit</b> (Unit) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public decimal Unit;
    }

    /// <summary>
    /// Enumeration <b>FlowDirectionType1Code</b> (Flow Direction Type 1Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public enum FlowDirectionType1Code
    {

        /// <summary>
        /// <b>INCG - Incoming</b>.
        /// </summary>
        INCG,

        /// <summary>
        /// <b>OUTG - Outgoing</b>.
        /// </summary>
        OUTG,
    }

    /// <summary>
    /// Class <b>NetCashForecast2</b> (Net Cash Forecast 2).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class NetCashForecast2
    {

        /// <summary>
        /// Element <b>CshSttlmDt</b> (Cash Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 0 )]
        public System.DateTime CshSttlmDt;

        /// <summary>
        /// Element <b>NetAmt</b> (Net Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public ActiveOrHistoricCurrencyAndAmount NetAmt;

        /// <summary>
        /// Element <b>NetUnitsNb</b> (Net Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public FinancialInstrumentQuantity1 NetUnitsNb;

        /// <summary>
        /// Element <b>FlowDrctn</b> (Flow Direction) of type FlowDirectionType1Code.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public FlowDirectionType1Code FlowDrctn;
    }

    /// <summary>
    /// Class <b>CashOutForecast4</b> (Cash Out Forecast 4).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class CashOutForecast4
    {

        /// <summary>
        /// Element <b>CshSttlmDt</b> (Cash Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 0 )]
        public System.DateTime CshSttlmDt;

        /// <summary>
        /// Element <b>SubTtlAmt</b> (Sub Total Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public ActiveOrHistoricCurrencyAndAmount SubTtlAmt;

        /// <summary>
        /// Element <b>SubTtlUnitsNb</b> (Sub Total Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public FinancialInstrumentQuantity1 SubTtlUnitsNb;

        /// <summary>
        /// Element <b>XcptnlCshFlowInd</b> (Exceptional Cash Flow Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public bool XcptnlCshFlowInd;

        /// <summary>
        /// Element <b>XcptnlCshFlowIndSpecified</b> (Exceptional Cash Flow Indicator Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool XcptnlCshFlowIndSpecified;
    }

    /// <summary>
    /// Class <b>CashInForecast4</b> (Cash In Forecast 4).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class CashInForecast4
    {

        /// <summary>
        /// Element <b>CshSttlmDt</b> (Cash Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 0 )]
        public System.DateTime CshSttlmDt;

        /// <summary>
        /// Element <b>SubTtlAmt</b> (Sub Total Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public ActiveOrHistoricCurrencyAndAmount SubTtlAmt;

        /// <summary>
        /// Element <b>SubTtlUnitsNb</b> (Sub Total Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public FinancialInstrumentQuantity1 SubTtlUnitsNb;

        /// <summary>
        /// Element <b>XcptnlCshFlowInd</b> (Exceptional Cash Flow Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public bool XcptnlCshFlowInd;

        /// <summary>
        /// Element <b>XcptnlCshFlowIndSpecified</b> (Exceptional Cash Flow Indicator Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool XcptnlCshFlowIndSpecified;
    }

    /// <summary>
    /// Class <b>AlternateSecurityIdentification1</b> (Alternate Security Identification 1).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class AlternateSecurityIdentification1
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute( "DmstIdSrc", typeof( string ), Order = 1 )]
        [XmlElementAttribute( "PrtryIdSrc", typeof( string ), Order = 1 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public string Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03", IncludeInSchema = false )]
    public enum ItemChoiceType1
    {

        /// <summary>
        /// <b>DmstIdSrc - ?undefined</b>.
        /// </summary>
        DmstIdSrc,

        /// <summary>
        /// <b>PrtryIdSrc - ?undefined</b>.
        /// </summary>
        PrtryIdSrc,
    }

    /// <summary>
    /// Class <b>SecurityIdentification3Choice</b> (Security Identification 3Choice).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class SecurityIdentification3Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Belgn of type string 
        ///  Blmbrg of type string 
        ///  CTA of type string 
        ///  CUSIP of type string 
        ///  Cmon of type string 
        ///  Dtch of type string 
        ///  ISIN of type string 
        ///  OthrPrtryId of type AlternateSecurityIdentification1 
        ///  QUICK of type string 
        ///  RIC of type string 
        ///  SCVM of type string 
        ///  SEDOL of type string 
        ///  TckrSymb of type string 
        ///  Vlrn of type string 
        ///  Wrtppr of type string 
        /// </summary>
        [XmlElementAttribute( "Belgn", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Blmbrg", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "CTA", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "CUSIP", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Cmon", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Dtch", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "ISIN", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "OthrPrtryId", typeof( AlternateSecurityIdentification1 ), Order = 0 )]
        [XmlElementAttribute( "QUICK", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "RIC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "SCVM", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "SEDOL", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "TckrSymb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Vlrn", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Wrtppr", typeof( string ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public object Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType2.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType2</b> (Item Choice Type 2).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03", IncludeInSchema = false )]
    public enum ItemChoiceType2
    {

        /// <summary>
        /// <b>Belgn - ?undefined</b>.
        /// </summary>
        Belgn,

        /// <summary>
        /// <b>Blmbrg - ?undefined</b>.
        /// </summary>
        Blmbrg,

        /// <summary>
        /// <b>CTA - ?undefined</b>.
        /// </summary>
        CTA,

        /// <summary>
        /// <b>CUSIP - ?undefined</b>.
        /// </summary>
        CUSIP,

        /// <summary>
        /// <b>Cmon - ?undefined</b>.
        /// </summary>
        Cmon,

        /// <summary>
        /// <b>Dtch - ?undefined</b>.
        /// </summary>
        Dtch,

        /// <summary>
        /// <b>ISIN - ?undefined</b>.
        /// </summary>
        ISIN,

        /// <summary>
        /// <b>OthrPrtryId - ?undefined</b>.
        /// </summary>
        OthrPrtryId,

        /// <summary>
        /// <b>QUICK - ?undefined</b>.
        /// </summary>
        QUICK,

        /// <summary>
        /// <b>RIC - ?undefined</b>.
        /// </summary>
        RIC,

        /// <summary>
        /// <b>SCVM - ?undefined</b>.
        /// </summary>
        SCVM,

        /// <summary>
        /// <b>SEDOL - ?undefined</b>.
        /// </summary>
        SEDOL,

        /// <summary>
        /// <b>TckrSymb - ?undefined</b>.
        /// </summary>
        TckrSymb,

        /// <summary>
        /// <b>Vlrn - ?undefined</b>.
        /// </summary>
        Vlrn,

        /// <summary>
        /// <b>Wrtppr - ?undefined</b>.
        /// </summary>
        Wrtppr,
    }

    /// <summary>
    /// Class <b>FinancialInstrument9</b> (Financial Instrument 9).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class FinancialInstrument9
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type SecurityIdentification3Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public SecurityIdentification3Choice Id;

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Nm;

        /// <summary>
        /// Element <b>SplmtryId</b> (Supplementary Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string SplmtryId;

        /// <summary>
        /// Element <b>ReqdNAVCcy</b> (Requested NAVCurrency) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string ReqdNAVCcy;

        /// <summary>
        /// Element <b>ClssTp</b> (Class Type) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string ClssTp;

        /// <summary>
        /// Element <b>SctiesForm</b> (Securities Form) of type FormOfSecurity1Code.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public FormOfSecurity1Code SctiesForm;

        /// <summary>
        /// Element <b>SctiesFormSpecified</b> (Securities Form Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SctiesFormSpecified;

        /// <summary>
        /// Element <b>DstrbtnPlcy</b> (Distribution Policy) of type DistributionPolicy1Code.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public DistributionPolicy1Code DstrbtnPlcy;

        /// <summary>
        /// Element <b>DstrbtnPlcySpecified</b> (Distribution Policy Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DstrbtnPlcySpecified;

        /// <summary>
        /// Element <b>DualFndInd</b> (Dual Fund Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public bool DualFndInd;
    }

    /// <summary>
    /// Enumeration <b>FormOfSecurity1Code</b> (Form Of Security 1Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public enum FormOfSecurity1Code
    {

        /// <summary>
        /// <b>BEAR - Bearer</b>.
        /// </summary>
        BEAR,

        /// <summary>
        /// <b>REGD - Registered</b>.
        /// </summary>
        REGD,
    }

    /// <summary>
    /// Enumeration <b>DistributionPolicy1Code</b> (Distribution Policy 1Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public enum DistributionPolicy1Code
    {

        /// <summary>
        /// <b>DIST - Distribution</b>.
        /// </summary>
        DIST,

        /// <summary>
        /// <b>ACCU - Accumulation</b>.
        /// </summary>
        ACCU,
    }

    /// <summary>
    /// Class <b>DateAndDateTimeChoice</b> (Date And Date Time Choice).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class DateAndDateTimeChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( "Dt", typeof( System.DateTime ), DataType = "date", Order = 0 )]
        [XmlElementAttribute( "DtTm", typeof( System.DateTime ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public System.DateTime Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03", IncludeInSchema = false )]
    public enum ItemChoiceType
    {

        /// <summary>
        /// <b>Dt - ?undefined</b>.
        /// </summary>
        Dt,

        /// <summary>
        /// <b>DtTm - ?undefined</b>.
        /// </summary>
        DtTm,
    }

    /// <summary>
    /// Class <b>EstimatedFundCashForecast3</b> (Estimated Fund Cash Forecast 3).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class EstimatedFundCashForecast3
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>TradDtTm</b> (Trade Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public DateAndDateTimeChoice TradDtTm;

        /// <summary>
        /// Element <b>PrvsTradDtTm</b> (Previous Trade Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public DateAndDateTimeChoice PrvsTradDtTm;

        /// <summary>
        /// Element <b>FinInstrmDtls</b> (Financial Instrument Details) of type FinancialInstrument9.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public FinancialInstrument9 FinInstrmDtls;

        /// <summary>
        /// Element <b>EstmtdTtlNAV</b> (Estimated Total NAV) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public ActiveOrHistoricCurrencyAndAmount EstmtdTtlNAV;

        /// <summary>
        /// Element <b>PrvsTtlNAV</b> (Previous Total NAV) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public ActiveOrHistoricCurrencyAndAmount PrvsTtlNAV;

        /// <summary>
        /// Element <b>EstmtdTtlUnitsNb</b> (Estimated Total Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public FinancialInstrumentQuantity1 EstmtdTtlUnitsNb;

        /// <summary>
        /// Element <b>PrvsTtlUnitsNb</b> (Previous Total Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public FinancialInstrumentQuantity1 PrvsTtlUnitsNb;

        /// <summary>
        /// Element <b>EstmtdTtlNAVChngRate</b> (Estimated Total NAVChange Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public decimal EstmtdTtlNAVChngRate;

        /// <summary>
        /// Element <b>EstmtdTtlNAVChngRateSpecified</b> (Estimated Total NAVChange Rate Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool EstmtdTtlNAVChngRateSpecified;

        /// <summary>
        /// Element <b>InvstmtCcy</b> (Investment Currency) of type array of string.
        /// </summary>
        [XmlElementAttribute( "InvstmtCcy", Order = 9 )]
        public string[] InvstmtCcy;

        /// <summary>
        /// Element <b>XcptnlNetCshFlowInd</b> (Exceptional Net Cash Flow Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public bool XcptnlNetCshFlowInd;

        /// <summary>
        /// Element <b>EstmtdCshInFcstDtls</b> (Estimated Cash In Forecast Details) of type array of CashInForecast4.
        /// </summary>
        [XmlElementAttribute( "EstmtdCshInFcstDtls", Order = 11 )]
        public CashInForecast4[] EstmtdCshInFcstDtls;

        /// <summary>
        /// Element <b>EstmtdCshOutFcstDtls</b> (Estimated Cash Out Forecast Details) of type array of CashOutForecast4.
        /// </summary>
        [XmlElementAttribute( "EstmtdCshOutFcstDtls", Order = 12 )]
        public CashOutForecast4[] EstmtdCshOutFcstDtls;

        /// <summary>
        /// Element <b>EstmtdNetCshFcstDtls</b> (Estimated Net Cash Forecast Details) of type array of NetCashForecast2.
        /// </summary>
        [XmlElementAttribute( "EstmtdNetCshFcstDtls", Order = 13 )]
        public NetCashForecast2[] EstmtdNetCshFcstDtls;
    }

    /// <summary>
    /// Class <b>Pagination</b> (Pagination).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class Pagination
    {

        /// <summary>
        /// Element <b>PgNb</b> (Page Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string PgNb;

        /// <summary>
        /// Element <b>LastPgInd</b> (Last Page Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public bool LastPgInd;
    }

    /// <summary>
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class PostalAddress1
    {

        /// <summary>
        /// Element <b>AdrTp</b> (Address Type) of type AddressType2Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AddressType2Code AdrTp;

        /// <summary>
        /// Element <b>AdrTpSpecified</b> (Address Type Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AdrTpSpecified;

        /// <summary>
        /// Element <b>AdrLine</b> (Address Line) of type array of string.
        /// </summary>
        [XmlElementAttribute( "AdrLine", Order = 1 )]
        public string[] AdrLine;

        /// <summary>
        /// Element <b>StrtNm</b> (Street Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string StrtNm;

        /// <summary>
        /// Element <b>BldgNb</b> (Building Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string BldgNb;

        /// <summary>
        /// Element <b>PstCd</b> (Post Code) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string PstCd;

        /// <summary>
        /// Element <b>TwnNm</b> (Town Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public string TwnNm;

        /// <summary>
        /// Element <b>CtrySubDvsn</b> (Country Sub Division) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public string CtrySubDvsn;

        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public string Ctry;
    }

    /// <summary>
    /// Enumeration <b>AddressType2Code</b> (Address Type 2Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public enum AddressType2Code
    {

        /// <summary>
        /// <b>ADDR - Postal</b>.
        /// </summary>
        ADDR,

        /// <summary>
        /// <b>PBOX - POBox</b>.
        /// </summary>
        PBOX,

        /// <summary>
        /// <b>HOME - Residential</b>.
        /// </summary>
        HOME,

        /// <summary>
        /// <b>BIZZ - Business</b>.
        /// </summary>
        BIZZ,

        /// <summary>
        /// <b>MLTO - Mail To</b>.
        /// </summary>
        MLTO,

        /// <summary>
        /// <b>DLVY - Delivery To</b>.
        /// </summary>
        DLVY,
    }

    /// <summary>
    /// Class <b>NameAndAddress5</b> (Name And Address 5).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class NameAndAddress5
    {

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Nm;

        /// <summary>
        /// Element <b>Adr</b> (Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PostalAddress1 Adr;
    }

    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class GenericIdentification1
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>SchmeNm</b> (Scheme Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string SchmeNm;

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Issr;
    }

    /// <summary>
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class PartyIdentification2Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  BICOrBEI of type string 
        ///  NmAndAdr of type NameAndAddress5 
        ///  PrtryId of type GenericIdentification1 
        /// </summary>
        [XmlElementAttribute( "BICOrBEI", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "NmAndAdr", typeof( NameAndAddress5 ), Order = 0 )]
        [XmlElementAttribute( "PrtryId", typeof( GenericIdentification1 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>AdditionalReference3</b> (Additional Reference 3).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.040.001.03" )]
    public class AdditionalReference3
    {

        /// <summary>
        /// Element <b>Ref</b> (Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Ref;

        /// <summary>
        /// Element <b>RefIssr</b> (Reference Issuer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification2Choice RefIssr;

        /// <summary>
        /// Element <b>MsgNm</b> (Message Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string MsgNm;
    }
}