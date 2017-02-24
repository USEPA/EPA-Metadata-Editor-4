using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using System.Xml.Serialization;
using System.Reflection;
using System.Data;
using System.Runtime.InteropServices;
using System.IO;


namespace EmeLibrary
{
    public class isoNodes
    {
        public XmlNodeXpathtoElements IsoNodeXpaths = new XmlNodeXpathtoElements();
        
        //private List<string> classFieldBindingNames;
        private XmlDocument inboundMetadataRecord;
        private XmlDocument inboundMetadataRecordSkippedElements;
        private string _inboundMetadataRecordSkippedElementsXmlString;
        private string inboundMetadataFormat;
        private string inboundMetadataFilePath;
        private XmlDocument outboundMetadataRecord;
        private XmlDocument templateMetadataRecord;
        //private XmlDocument codeListsArcISO;
        //private XmlNode root19115;
        //private XmlNode root191152;
        private XmlNamespaceManager isoNsManager;
        
        //Metadata Information
        private string fileid;
        private string _language;
        private string hyLevel_md_scopeCode;        
        private List<CI_ResponsibleParty> _contactRpSection;
        private string _dateStamp;
        private string mdStandardName;
        private string mdStandardVersion;

        //idInfo Section
        private string _idInfo_citation_title;
        private string _idInfo_citation_date_creation;
        private string _idInfo_citation_date_publication;
        private string _idInfo_citation_date_revision;
        private List<CI_ResponsibleParty> idinfoCitationcitedResponsibleParty;

        private string _idInfo_abstract;
        private string _idInfo_purpose;
        private string _idInfo_status_MD_ProgressCode;
        private List<CI_ResponsibleParty> idinfoPointOfContact;
        private string _idInfo_resourceMaintenance;
        
        private List<string> kwEpaList;
        private List<string> kwUserList;
        private List<string> kwPlaceList;
        private List<string> kwIsoTopicCatList;

        private string _idInfo_resourceConstraints_MD_Constraints_useLimitation;
        private string _idInfo_resourceConstraints_MD_LegalConstraints_useLimitation;
        private string _idInfo_resourceConstraints_MD_LegalConstraints_accessConstraints;
        private string _idInfo_resourceConstraints_MD_LegalConstraints_useConstraints;
        private string _idInfo_resourceConstraints_MD_LegalConstraints_otherConstraints;
        private string _idInfo_resourceConstraints_MD_SecurityConstraints_useLimitation;
        private string _idInfo_resourceConstraints_MD_SecurityConstraints_classification;
        private string _idInfo_resourceConstraints_MD_SecurityConstraints_userNote;
        private string _idInfo_resourceConstraints_MD_SecurityConstraints_classificationSystem;
        private string _idInfo_resourceConstraints_MD_SecurityConstraints_handlingDescription;

        private string _idInfo_extent_description;
        private double _idInfo_extent_geographicBoundingBox_westLongDD;
        private double _idInfo_extent_geographicBoundingBox_eastLongDD;
        private double _idInfo_extent_geographicBoundingBox_southLatDD;
        private double _idInfo_extent_geographicBoundingBox_northLatDD;        

        private temporalElement__EX_TemporalExtent _idInfo_extent_temporalExtent;


        private List<MD_Distributor> _distributionInfo__MD_Distribution;
               
        
        #region Public Properties Section

        //public List<string> ClassFieldNames { get { return classFieldBindingNames; } }
        
        public string baseURIFileName
        {
            get { return inboundMetadataRecord.BaseURI.ToString(); }
        }
        public string elementsNotEditedByEME
        {
            get { return _inboundMetadataRecordSkippedElementsXmlString; }
        }
        public string fileIdentifier
        {
            get { return fileid; }
            set { fileid = value; }
        }
        public string language
        {
            get { return _language; }
            set { _language = value; }
        }
        public string hierarchyLevel_MD_ScopeCode
        {
            get { return hyLevel_md_scopeCode; }
            set { hyLevel_md_scopeCode = value; }
        }        
        public List<CI_ResponsibleParty> contact_CI_ResponsibleParty
        {
            get { return _contactRpSection; }
            set { _contactRpSection = value; }
        }
        public string dateStamp
        {
            get { return _dateStamp; }
            set { _dateStamp = value; }
        }
        public string metadataStandardName
        {
            get { return mdStandardName; }
            set { mdStandardName = value; }
        }  //Not sure how we should populate these... maybe always from the template!
        public string metadataStandardVersion
        { 
            get { return mdStandardVersion; }
            set { mdStandardVersion = value; }
        }
        public string idInfo_citation_Title
        {
            get { return _idInfo_citation_title; }
            set { _idInfo_citation_title = value; }
        }
        public string idInfo_citation_date_creation
        {
            get { return _idInfo_citation_date_creation; }
            set { _idInfo_citation_date_creation = value; }
        }
        public string idInfo_citation_date_publication
        {
            get { return _idInfo_citation_date_publication; }
            set { _idInfo_citation_date_publication = value; }
        }
        public string idInfo_citation_date_revision
        {
            get { return _idInfo_citation_date_revision; }
            set { _idInfo_citation_date_revision = value; }
        }
        public List<CI_ResponsibleParty> idInfo_citation_citedResponsibleParty
        {
            get { return idinfoCitationcitedResponsibleParty; }
            set { idinfoCitationcitedResponsibleParty = value; }
        }                        
        public string idInfo_Abstract
        {
            get { return _idInfo_abstract; }
            set { _idInfo_abstract = value; }
        }
        public string idInfo_Purpose
        {
            get { return _idInfo_purpose; }
            set { _idInfo_purpose = value; }
        }
        public string idInfo_Status_MD_ProgressCode
        {
            get { return _idInfo_status_MD_ProgressCode; }
            set { _idInfo_status_MD_ProgressCode = value; }
        }
        public List<CI_ResponsibleParty> idInfo_pointOfContact
        {
            get { return idinfoPointOfContact; }
            set { idinfoPointOfContact = value; }
        }
        public string idInfo_resourceMaintenance
        {
            get { return _idInfo_resourceMaintenance; }
            set { _idInfo_resourceMaintenance = value; }
        }
        public List<string> idInfo_keywordsEpa
        {
            get { return kwEpaList; }
            set { kwEpaList = value; }
        }
        public List<string> idInfo_keywordsUser
        {
            get { return kwUserList; }
            set { kwUserList = value; }
        }
        public List<string> idInfo_keywordsPlace
        {
            get { return kwPlaceList; }
            set { kwPlaceList = value; }
        }
        public List<string> idInfo_keywordsIsoTopicCategory
        {
            get { return kwIsoTopicCatList; }
            set { kwIsoTopicCatList = value; }
        }
        //Section 12
        public string idInfo_resourceConstraints_MD_Constraints_useLimitation
        {
            get { return _idInfo_resourceConstraints_MD_Constraints_useLimitation; }
            set { _idInfo_resourceConstraints_MD_Constraints_useLimitation = value; }
        }
        public string idInfo_resourceConstraints_MD_LegalConstraints_useLimitation
        {
            get { return _idInfo_resourceConstraints_MD_LegalConstraints_useLimitation; }
            set { _idInfo_resourceConstraints_MD_LegalConstraints_useLimitation = value; }
        }
        public string idInfo_resourceConstraints_MD_LegalConstraints_accessConstraints
        {
            get {return _idInfo_resourceConstraints_MD_LegalConstraints_accessConstraints; }
            set { _idInfo_resourceConstraints_MD_LegalConstraints_accessConstraints = value; }
        }
        public string idInfo_resourceConstraints_MD_LegalConstraints_useConstraints
        {
            get { return _idInfo_resourceConstraints_MD_LegalConstraints_useConstraints ; }
            set { _idInfo_resourceConstraints_MD_LegalConstraints_useConstraints = value; }
        }
        public string idInfo_resourceConstraints_MD_LegalConstraints_otherConstraints
        {
            get { return _idInfo_resourceConstraints_MD_LegalConstraints_otherConstraints; }
            set { _idInfo_resourceConstraints_MD_LegalConstraints_otherConstraints = value;}
        }
        public string idInfo_resourceConstraints_MD_SecurityConstraints_useLimitation
        {
            get { return _idInfo_resourceConstraints_MD_SecurityConstraints_useLimitation ; }
            set {_idInfo_resourceConstraints_MD_SecurityConstraints_useLimitation  = value; }
        }
        public string idInfo_resourceConstraints_MD_SecurityConstraints_classification
        {
            get { return _idInfo_resourceConstraints_MD_SecurityConstraints_classification; }
            set {_idInfo_resourceConstraints_MD_SecurityConstraints_classification  = value; }
        }
        public string idInfo_resourceConstraints_MD_SecurityConstraints_userNote
        {
            get { return _idInfo_resourceConstraints_MD_SecurityConstraints_userNote; }
            set { _idInfo_resourceConstraints_MD_SecurityConstraints_userNote = value; }
        }
        public string idInfo_resourceConstraints_MD_SecurityConstraints_classificationSystem
        {
            get { return _idInfo_resourceConstraints_MD_SecurityConstraints_classificationSystem; }
            set { _idInfo_resourceConstraints_MD_SecurityConstraints_classificationSystem = value; }
        }
        public string idInfo_resourceConstraints_MD_SecurityConstraints_handlingDescription
        {
            get { return _idInfo_resourceConstraints_MD_SecurityConstraints_handlingDescription; }
            set { _idInfo_resourceConstraints_MD_SecurityConstraints_handlingDescription = value; }
        }

        //Section 20
        public string idInfo_extent_description
        {
            get { return _idInfo_extent_description; }
            set { _idInfo_extent_description = value; }
        }
        public double idInfo_extent_geographicBoundingBox_westLongDD
        {
            get { return _idInfo_extent_geographicBoundingBox_westLongDD; }
            set { _idInfo_extent_geographicBoundingBox_westLongDD = value; }
        }
        public double idInfo_extent_geographicBoundingBox_eastLongDD
        {
            get { return _idInfo_extent_geographicBoundingBox_eastLongDD; }
            set { _idInfo_extent_geographicBoundingBox_eastLongDD = value; }
        }
        public double idInfo_extent_geographicBoundingBox_southLatDD
        {
            get { return _idInfo_extent_geographicBoundingBox_southLatDD; }
            set { _idInfo_extent_geographicBoundingBox_southLatDD = value; }
        }
        public double idInfo_extent_geographicBoundingBox_northLatDD
        {
            get { return _idInfo_extent_geographicBoundingBox_northLatDD; }
            set { _idInfo_extent_geographicBoundingBox_northLatDD = value; }
        }
        public temporalElement__EX_TemporalExtent idInfo_extent_temporalExtent
        {
            get { return _idInfo_extent_temporalExtent; }
            set { _idInfo_extent_temporalExtent = value; }
        }
        public List<MD_Distributor> distributionInfo__MD_Distribution
        {
            get { return _distributionInfo__MD_Distribution; }
            set { _distributionInfo__MD_Distribution = value; }
        }

       
        ////<gmd:contentInfo>
        //<gmd:distributionInfo>
        ////<gmd:dataQualityInfo>
        ////<gmd:metadataMaintenance>

        #endregion
        
        public isoNodes(XmlDocument xdoc, string sourceXMLFormat, string fileNamewithFullPath)
        {
            try
            {

                //Set Metadata format and file path and then set fields
                //ToDo:  Handle newly created files.  Will have to overload this method incase we are dealing with ArcObjects

                //Store inbound record.  Idea is to have both an inbound and outbound metadata record           
                inboundMetadataRecord = xdoc;

                //Make a copy and remove the elements that were handeled so we have a document of all the unsupported elements.
                StringWriter sw = new StringWriter();
                XmlTextWriter xw = new XmlTextWriter(sw);
                xw.Formatting = Formatting.Indented;
                xdoc.WriteTo(xw);
                string xdocCopy = sw.ToString();
                sw.Close();
                xw.Close();
                inboundMetadataRecordSkippedElements = new XmlDocument();
                if (!string.IsNullOrEmpty(xdocCopy))
                {
                    inboundMetadataRecordSkippedElements.LoadXml(xdocCopy);
                }
                else
                {
                    inboundMetadataRecordSkippedElements.LoadXml("<Empty/>");
                }


                // = xdoc;
                inboundMetadataFormat = sourceXMLFormat;
                inboundMetadataFilePath = fileNamewithFullPath;

                //Depending on the format detected, load the correct template record to for the outgoing metadata record
                //(gmd:MD_Metdata = 19115, gmi:MI_Metadata = 19115-2; metadata = both CSDGM and ArcGIS)
                templateMetadataRecord = new XmlDocument();
                if (inboundMetadataFormat == "ISO19115-2")
                {
                    templateMetadataRecord.Load(Utils1.EmeUserAppDataFolder + "\\Eme4xSystemFiles\\EMEdb\\MItemplate.xml");
                }
                else if (inboundMetadataFormat == "ISO19115")
                {
                    templateMetadataRecord.Load(Utils1.EmeUserAppDataFolder + "\\Eme4xSystemFiles\\EMEdb\\MDtemplate.xml");
                }
                else
                {
                    //do something; not sure what yet  :-)
                }

                //NameSpace and schema specific to 19115 and -2.  Trying to avoid using this or some other work around for multiple standards.
                //setISONameSpaceManager();

                //codeListsArcISO = new XmlDocument();

                bindclassXpathProperties();

                if (fileNamewithFullPath == "New")
                {
                    //Set new instances for object fields
                    kwEpaList = new List<string>();
                    kwIsoTopicCatList = new List<string>();
                    kwPlaceList = new List<string>();
                    kwUserList = new List<string>();
                    _contactRpSection = new List<CI_ResponsibleParty>();
                    idinfoCitationcitedResponsibleParty = new List<CI_ResponsibleParty>();

                    idinfoPointOfContact = new List<CI_ResponsibleParty>();
                    _idInfo_extent_temporalExtent = new temporalElement__EX_TemporalExtent();
                    _distributionInfo__MD_Distribution = new List<MD_Distributor>();
                    mdStandardName = templateMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.metadataStandardNameXpath).FirstChild.InnerText;
                    mdStandardVersion = templateMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.metadataStandardVersionXpath).FirstChild.InnerText;



                }
                else
                {

                    //Metadata Information
                    fileid = returnInnerTextfromNode(IsoNodeXpaths.fileIdentifierXpath);
                    _language = returnInnerTextfromNode(IsoNodeXpaths.languageXpath);
                    hyLevel_md_scopeCode = returnInnerTextfromNode(IsoNodeXpaths.hierarchyLevel_MD_ScopeCodeXpath);
                    //check that there is a contact
                    _contactRpSection = returnCI_ResponsiblePartyList(IsoNodeXpaths.contact_CI_ResponsiblePartyXpath);
                    _dateStamp = returnInnerTextfromNode(IsoNodeXpaths.dateStampXpath);
                    //Might get this from template metadata instead and leave as read-only
                    mdStandardName = templateMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.metadataStandardNameXpath).FirstChild.InnerText;
                    mdStandardVersion = templateMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.metadataStandardVersionXpath).FirstChild.InnerText;

                    XmlNode deleteMDInfo = inboundMetadataRecordSkippedElements.DocumentElement.SelectSingleNode("./*[local-name()='characterSet']");
                    if (deleteMDInfo != null)
                    {
                        deleteMDInfo.RemoveAll();
                        removeEmptyParentNodes(deleteMDInfo);
                    }
                    deleteMDInfo = inboundMetadataRecordSkippedElements.DocumentElement.SelectSingleNode("./*[local-name()='metadataStandardName']");
                    if (deleteMDInfo != null)
                    {
                        deleteMDInfo.RemoveAll();
                        removeEmptyParentNodes(deleteMDInfo);
                    }
                    deleteMDInfo = inboundMetadataRecordSkippedElements.DocumentElement.SelectSingleNode("./*[local-name()='metadataStandardVersion']");
                    if (deleteMDInfo != null)
                    {
                        deleteMDInfo.RemoveAll();
                        removeEmptyParentNodes(deleteMDInfo);
                    }

                    //IdInfo
                    _idInfo_citation_title = returnInnerTextfromNode(IsoNodeXpaths.idInfo_citation_TitleXpath);

                    //Remove the compound dates first, then set class fields
                    XmlNode deleteCompoundElement = inboundMetadataRecordSkippedElements.DocumentElement.SelectSingleNode
                        (IsoNodeXpaths.idInfo_citation_date_creationXpath);
                    if (deleteCompoundElement != null)
                    {
                        XmlNode pNode = deleteCompoundElement.ParentNode;
                        pNode.RemoveAll();
                        removeEmptyParentNodes(pNode);
                    }
                    deleteCompoundElement = inboundMetadataRecordSkippedElements.DocumentElement.SelectSingleNode
                        (IsoNodeXpaths.idInfo_citation_date_publicationXpath);
                    if (deleteCompoundElement != null)
                    {
                        XmlNode pNode = deleteCompoundElement.ParentNode;
                        pNode.RemoveAll();
                        removeEmptyParentNodes(pNode);
                    }
                    deleteCompoundElement = inboundMetadataRecordSkippedElements.DocumentElement.SelectSingleNode
                        (IsoNodeXpaths.idInfo_citation_date_revisionXpath);
                    if (deleteCompoundElement != null)
                    {
                        XmlNode pNode = deleteCompoundElement.ParentNode;
                        pNode.RemoveAll();
                        removeEmptyParentNodes(pNode);
                    }

                    _idInfo_citation_date_creation = returnInnerTextfromNode(IsoNodeXpaths.idInfo_citation_date_creationXpath);
                    _idInfo_citation_date_publication = returnInnerTextfromNode(IsoNodeXpaths.idInfo_citation_date_publicationXpath);
                    _idInfo_citation_date_revision = returnInnerTextfromNode(IsoNodeXpaths.idInfo_citation_date_revisionXpath);

                    idinfoCitationcitedResponsibleParty = returnCI_ResponsiblePartyList(IsoNodeXpaths.idInfo_citation_citedResponsiblePartyXpath);

                    _idInfo_abstract = returnInnerTextfromNode(IsoNodeXpaths.idInfo_AbstractXpath);
                    _idInfo_purpose = returnInnerTextfromNode(IsoNodeXpaths.idInfo_PurposeXpath);
                    _idInfo_status_MD_ProgressCode = returnInnerTextfromNode(IsoNodeXpaths.idInfo_Status_MD_ProgressCodeXpath);
                    idinfoPointOfContact = returnCI_ResponsiblePartyList(IsoNodeXpaths.idInfo_pointOfContactXpath);

                    //Section 7 resourceMaintenance
                    _idInfo_resourceMaintenance = returnInnerTextfromNode(IsoNodeXpaths.idInfo_resourceMaintenanceXpath);

                    kwEpaList = returnListFromKeywordSection(IsoNodeXpaths.idInfo_keywordsEpaXpath, "./*[local-name()='MD_Keywords']/*[local-name()='keyword']");
                    //returnListFromNodeList(inboundMetadataRecord.DocumentElement.SelectNodes(IsoNodeXpaths.IdInfo_keywordsEpaListXpath));
                    kwPlaceList = returnListFromKeywordSection(IsoNodeXpaths.idInfo_keywordsPlaceXpath, "./*[local-name()='MD_Keywords']/*[local-name()='keyword']");
                    kwUserList = returnListFromKeywordSection(IsoNodeXpaths.idInfo_keywordsUserXpath, "./*[local-name()='MD_Keywords']/*[local-name()='keyword']");
                    kwIsoTopicCatList = returnListFromTopicCatKeywordSection(IsoNodeXpaths.idInfo_keywordsIsoTopicCategoryXpath);
                        //returnListFromKeywordSection(IsoNodeXpaths.idInfo_keywordsIsoTopicCategoryXpath, "./*[local-name()='MD_TopicCategoryCode']");

                    //Section 12 resourceConstraints
                    _idInfo_resourceConstraints_MD_Constraints_useLimitation =
                        returnInnerTextfromNode(IsoNodeXpaths.idInfo_resourceConstraints_MD_Constraints_useLimitationXpath);
                    _idInfo_resourceConstraints_MD_LegalConstraints_useLimitation =
                        returnInnerTextfromNode(IsoNodeXpaths.idInfo_resourceConstraints_MD_LegalConstraints_useLimitationXpath);
                    _idInfo_resourceConstraints_MD_LegalConstraints_accessConstraints =
                        returnInnerTextfromNode(IsoNodeXpaths.idInfo_resourceConstraints_MD_LegalConstraints_accessConstraintsXpath);
                    _idInfo_resourceConstraints_MD_LegalConstraints_useConstraints =
                        returnInnerTextfromNode(IsoNodeXpaths.idInfo_resourceConstraints_MD_LegalConstraints_useConstraintsXpath);
                    _idInfo_resourceConstraints_MD_LegalConstraints_otherConstraints =
                        returnInnerTextfromNode(IsoNodeXpaths.idInfo_resourceConstraints_MD_LegalConstraints_otherConstraintsXpath);
                    _idInfo_resourceConstraints_MD_SecurityConstraints_useLimitation =
                        returnInnerTextfromNode(IsoNodeXpaths.idInfo_resourceConstraints_MD_SecurityConstraints_useLimitationXpath);
                    _idInfo_resourceConstraints_MD_SecurityConstraints_classification =
                        returnInnerTextfromNode(IsoNodeXpaths.idInfo_resourceConstraints_MD_SecurityConstraints_classificationXpath);
                    _idInfo_resourceConstraints_MD_SecurityConstraints_userNote =
                        returnInnerTextfromNode(IsoNodeXpaths.idInfo_resourceConstraints_MD_SecurityConstraints_userNoteXpath);
                    _idInfo_resourceConstraints_MD_SecurityConstraints_classificationSystem =
                        returnInnerTextfromNode(IsoNodeXpaths.idInfo_resourceConstraints_MD_SecurityConstraints_classificationSystemXpath);
                    _idInfo_resourceConstraints_MD_SecurityConstraints_handlingDescription =
                        returnInnerTextfromNode(IsoNodeXpaths.idInfo_resourceConstraints_MD_SecurityConstraints_handlingDescriptionXpath);

                    //Section 16  //just remove the lanuague section
                    XmlNode delLan = inboundMetadataRecordSkippedElements.DocumentElement.SelectSingleNode(
                        "./*[local-name()='identificationInfo']/*[local-name()='MD_DataIdentification']/*[local-name()='language']");
                    if (delLan != null)
                    {
                        delLan.RemoveAll();
                        removeEmptyParentNodes(delLan);
                    }

                    _idInfo_extent_description = returnInnerTextfromNode(IsoNodeXpaths.idInfo_extent_descriptionXpath);
                    _idInfo_extent_geographicBoundingBox_eastLongDD = returnInnerTextfromNodeAsDouble(IsoNodeXpaths.idInfo_extent_geographicBoundingBox_eastLongDDXpath);
                    _idInfo_extent_geographicBoundingBox_westLongDD = returnInnerTextfromNodeAsDouble(IsoNodeXpaths.idInfo_extent_geographicBoundingBox_westLongDDXpath);
                    _idInfo_extent_geographicBoundingBox_northLatDD = returnInnerTextfromNodeAsDouble(IsoNodeXpaths.idInfo_extent_geographicBoundingBox_northLatDDXpath);
                    _idInfo_extent_geographicBoundingBox_southLatDD = returnInnerTextfromNodeAsDouble(IsoNodeXpaths.idInfo_extent_geographicBoundingBox_southLatDDXpath);

                    //Check which timeExtent is found in the document... if one is found.  If not found then leave each type null?
                    //Only populate one of the extents for now, even if more are present.
                    //This grabs the first occurance of time extent and populate timePeriod, or timeInstant
                    _idInfo_extent_temporalExtent = new temporalElement__EX_TemporalExtent();
                    #region temporalExtent Section
                    XmlNode temporalExtentNode = inboundMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.idInfo_extent_temporalExtentXpath);
                    if (temporalExtentNode != null)
                    {
                        //check which section we have.
                        //If both time instant and time period what do we do???
                        //For now this will grab a timePeriod and skip time instant if they both exist
                        //First one grabbed will be removed from the tree.

                        XmlNode nodeToDelete = inboundMetadataRecordSkippedElements.DocumentElement.SelectSingleNode(IsoNodeXpaths.idInfo_extent_temporalExtentXpath);
                        nodeToDelete.RemoveAll();
                        removeEmptyParentNodes(nodeToDelete);

                        string tExtentName = temporalExtentNode.FirstChild.Name;
                        if (tExtentName == "gml:TimePeriod")
                        {
                            timePeriodExtent tp = new timePeriodExtent();

                            tp.extent__TimePeriod__id = "boundingTimePeriodExtent1";//Make sure it is unique. We are assigning our own id.
                            tp.extent__TimePeriod__description = (temporalExtentNode.FirstChild.SelectSingleNode("./*[local-name()='description']") != null) ?
                                temporalExtentNode.FirstChild.SelectSingleNode("./*[local-name()='description']").InnerText : "";
                            //These could have the indeterminantPosition Attribute
                            //XmlNode attributeNode = targetNode.FirstChild.Attributes["codeListValue"];
                            //if (attributeNode != null) { targetNode.FirstChild.Attributes["codeListValue"].Value = nodeValue; }
                            XmlNode subNode = temporalExtentNode.FirstChild.SelectSingleNode("./*[local-name()='beginPosition']");
                            if (subNode != null)
                            {
                                DateTime dt;
                                bool isValueDate = DateTime.TryParse(subNode.InnerText, out dt);
                                if (isValueDate) { tp.extent__TimePeriod__beginPosition = subNode.InnerText; }
                                else
                                {
                                    XmlNode attributeNode = subNode.Attributes["indeterminatePosition"];
                                    if (attributeNode != null)
                                    {
                                        tp.extent__TimePeriod__beginPosition = (subNode.Attributes["indeterminatePosition"].Value != null) ?
                                            subNode.Attributes["indeterminatePosition"].Value : "unknown";
                                    }
                                }
                            }
                            subNode = temporalExtentNode.FirstChild.SelectSingleNode("./*[local-name()='endPosition']");
                            if (subNode != null)
                            {
                                DateTime dt;
                                bool isValueDate = DateTime.TryParse(subNode.InnerText, out dt);
                                if (isValueDate) { tp.extent__TimePeriod__endPosition = subNode.InnerText; }
                                else
                                {
                                    XmlNode attributeNode = subNode.Attributes["indeterminatePosition"];
                                    if (attributeNode != null)
                                    {
                                        tp.extent__TimePeriod__endPosition = (subNode.Attributes["indeterminatePosition"].Value != null) ?
                                            subNode.Attributes["indeterminatePosition"].Value : "unknown";
                                    }
                                }

                            }
                            subNode = temporalExtentNode.FirstChild.SelectSingleNode("./*[local-name()='timeInterval']");
                            if (subNode != null)
                            {
                                tp.extent__TimePeriod__timeInterval = subNode.InnerText;
                                tp.extent__TimePeriod__timeIntervalUnit = (subNode.Attributes["unit"] != null) ? subNode.Attributes["unit"].Value : "";
                            }

                            _idInfo_extent_temporalExtent.TimePeriod = tp;
                        }
                        else if (tExtentName == "gml:TimeInstant")
                        {
                            timeInstantExtent ti = new timeInstantExtent();
                            ti.extent__TimeInstant__id = "boundingTimeInstantExtent1";
                            //ti.extent__TimeInstant__description = 
                            //ti.extent__TimeInstant__timePosition = 
                            ti.extent__TimeInstant__description = (temporalExtentNode.FirstChild.SelectSingleNode("./*[local-name()='description']") != null) ?
                                temporalExtentNode.FirstChild.SelectSingleNode("./*[local-name()='description']").InnerText : "";

                            //ti.extent__TimeInstant__timePosition = "unknown";
                            XmlNode subNode = temporalExtentNode.FirstChild.SelectSingleNode("./*[local-name()='timePosition']");
                            if (subNode != null)
                            {
                                DateTime dt;
                                bool isValueDate = DateTime.TryParse(subNode.InnerText, out dt);
                                if (isValueDate) { ti.extent__TimeInstant__timePosition = subNode.InnerText; }
                                else
                                {
                                    XmlNode attributeNode = subNode.Attributes["indeterminatePosition"];
                                    if (attributeNode != null)
                                    {
                                        ti.extent__TimeInstant__timePosition = (subNode.Attributes["indeterminatePosition"].Value != null) ?
                                            subNode.Attributes["indeterminatePosition"].Value : "unknown";
                                    }
                                }
                            }

                            _idInfo_extent_temporalExtent.TimeInstant = ti;
                        }
                        //Console.WriteLine(tExtentName);

                    }
                    #endregion


                    //_distributionInfo_MD_Distribution = new List<MD_Distribution>();
                    //set the private backing field directly in the method since this object only occurs in this section.
                    returnMD_DistributionSection();
                    //Console.WriteLine("done");
                    XmlNodeList skippedElementCount = inboundMetadataRecordSkippedElements.DocumentElement.ChildNodes;
                    if (skippedElementCount.Count > 0)
                    {
                        StringWriter sw2 = new StringWriter();
                        XmlTextWriter xw2 = new XmlTextWriter(sw2);
                        xw2.Formatting = Formatting.Indented;
                        inboundMetadataRecordSkippedElements.WriteTo(xw2);
                        _inboundMetadataRecordSkippedElementsXmlString = sw2.ToString();
                        sw2.Close();
                        xw2.Close();
                    }

                }

                //****************Testing
                //constructMI_MetadataMarkUp();
            }
            catch (Exception e)
            {
                
            }
        }

        /// <summary>
        /// Code to populate class properties of all the required form fields and corresponding Xpath Expressions to select out the values
        /// depending on the MetadataStandard.
        /// </summary>
        private void bindclassXpathProperties()
        {                        
            Utils1.setEmeSettingsDataset();
            DataTable subTable = Utils1.emeSettingsDataset.Tables["emeControl"].Select().CopyToDataTable();
            //.Select("cSource = 'ISO19115'").CopyToDataTable();
            //classFieldBindingNames = new List<string>();
            object obj = this.IsoNodeXpaths;
            foreach (DataRow dr in subTable.Rows)
            {
                //string s = dr["propName"].ToString() + "  Value: " + dr["Iso19115_2"].ToString();
                string pname = dr["controlName"].ToString() + "Xpath";
                PropertyInfo propInfo = obj.GetType().GetProperty(pname);
                if (propInfo != null)
                {
                    propInfo.SetValue(obj, dr["Iso19115_2"].ToString(), null);
                    //classFieldBindingNames.Add(dr["propName"].ToString());
                }
            }
        }

        /// <summary>
        /// Pass in the required Xpath to return the inner text value from the inboundMetadataRecord
        /// The Xpath should point to the parent element.  This will return the value from the firstChild
        /// since it is usually gco:CharacterString and a non-repeating element
        /// </summary>
        /// <param name="XpathToSingleNode">Xpath to inboundMetadataRecord Element</param>
        /// <returns></returns>        
        private string returnInnerTextfromNode(string XpathToSingleNode)
        {
            string s = "";
            if (inboundMetadataRecord.DocumentElement.SelectSingleNode(XpathToSingleNode) != null)
            {
                XmlNode singleNode = inboundMetadataRecord.DocumentElement.SelectSingleNode(XpathToSingleNode).FirstChild;
                s = (singleNode != null) ? singleNode.InnerText : "";
                XmlNode deleteThisNode = inboundMetadataRecordSkippedElements.DocumentElement.SelectSingleNode(XpathToSingleNode);
                if (deleteThisNode != null)
                {
                    //node may be removed at a different point in time.
                    deleteThisNode.RemoveAll();
                    removeEmptyParentNodes(deleteThisNode);
                }
            }
            return s;
        }
        private double returnInnerTextfromNodeAsDouble(string XpathToSingleNode)
        {
            double dd = 0;
            if (inboundMetadataRecord.DocumentElement.SelectSingleNode(XpathToSingleNode) != null)
            {
                XmlNode singleNode = inboundMetadataRecord.DocumentElement.SelectSingleNode(XpathToSingleNode).FirstChild;
                bool tf = double.TryParse(singleNode.InnerText,out dd);

                XmlNode deleteThisNode = inboundMetadataRecordSkippedElements.DocumentElement.SelectSingleNode(XpathToSingleNode);
                deleteThisNode.RemoveAll();
                removeEmptyParentNodes(deleteThisNode);
                
            }
            return dd;
        }
        /// <summary>
        /// Gets the list of keywords from the Parent keyword section.  Keywords can occur in several places and the 
        /// list of keywords may be contained within a different xml markup.  I.e. MD_Keywords/keyword vs. MD_TopicCategoryCode
        /// </summary>
        /// <param name="XpathToDescriptiveKeyWordSection">Xpath to main Parent section</param>
        /// <param name="XpathToListWithinSection">Xpath to child nodelist within Parent section</param>
        /// <returns></returns>
        private List<string> returnListFromKeywordSection(string XpathToDescriptiveKeyWordSection, string XpathToListWithinSection)
        {
            List<string> templist = new List<string>();
            //The first Xpath Expression should return one descriptive keywords section.
            //Then from that selection return a nodelist of keywords
            XmlNode kwSection = inboundMetadataRecord.DocumentElement.SelectSingleNode(XpathToDescriptiveKeyWordSection);
            if (kwSection != null)
            {
                XmlNodeList targetKeywordList = kwSection.SelectNodes(XpathToListWithinSection);//"./*[local-name()='keyword']");
                if (targetKeywordList != null)
                {
                    foreach (XmlNode n in targetKeywordList)
                    {
                        templist.Add(n.InnerText);
                    }
                }

                XmlNode kwSectionToDelete = inboundMetadataRecordSkippedElements.DocumentElement.SelectSingleNode(XpathToDescriptiveKeyWordSection);
                if (kwSectionToDelete != null)
                {
                    kwSectionToDelete.RemoveAll();
                    removeEmptyParentNodes(kwSectionToDelete);
                }
            }

            return templist;
            
        }
        private List<string> returnListFromTopicCatKeywordSection(string xpathToTopicKeyWordSection)
        {
            List<string> templist = new List<string>();

            XmlNodeList topicKwNl = inboundMetadataRecord.DocumentElement.SelectNodes(xpathToTopicKeyWordSection);
            foreach (XmlNode kwSection in topicKwNl)
            {

                //XmlNode kwSection = inboundMetadataRecord.DocumentElement.SelectSingleNode(XpathToDescriptiveKeyWordSection);
                if (kwSection != null)
                {
                    templist.Add(kwSection.FirstChild.InnerText);

                    //XmlNode kwSectionToDelete = inboundMetadataRecordSkippedElements.DocumentElement.SelectSingleNode(XpathToDescriptiveKeyWordSection);
                    //if (kwSectionToDelete != null)
                    //{
                    //    kwSectionToDelete.RemoveAll();
                    //    removeEmptyParentNodes(kwSectionToDelete);
                    //}
                }
            }
            XmlNodeList topicKwNl2 = inboundMetadataRecordSkippedElements.DocumentElement.SelectNodes(xpathToTopicKeyWordSection);
            foreach (XmlNode n in topicKwNl2)
            {
                if (n != null)
                {
                    n.RemoveAll();
                    removeEmptyParentNodes(n);
                }
            }

            return templist;

        }

        private List<string> returnListFromNodeList(XmlNodeList nodeList)
        {
            List<string> templist = new List<string>();
            if (nodeList != null)
            {
                foreach (XmlNode n in nodeList)
                {
                    templist.Add(n.InnerText);
                }
            }
            return templist;
        }

        /// <summary>
        /// Pass in the required Xpath to return the repeatable CI_ResponsibleParty component for the inboundMetadataRecord
        /// </summary>
        /// <param name="XpathToCI_RpSection">Xpath for NodeList of CI_ResponsibleParty</param>
        /// <returns></returns>
        private List<CI_ResponsibleParty> returnCI_ResponsiblePartyList (string XpathToCI_RpSection)//(XmlNodeList nodeListforCI_RpSection)
        {
            
            XmlNodeList nodeListToDelete = inboundMetadataRecordSkippedElements.DocumentElement.SelectNodes(XpathToCI_RpSection);
            foreach (XmlNode nd in nodeListToDelete)
            {
                nd.RemoveAll();
                removeEmptyParentNodes(nd);
            }
            
            XmlNodeList nodeListforCI_RpSection = inboundMetadataRecord.DocumentElement.SelectNodes(XpathToCI_RpSection);
            List<CI_ResponsibleParty> rpList = new List<CI_ResponsibleParty>();

            foreach (XmlNode n in nodeListforCI_RpSection)
            {
                if (n.HasChildNodes)
                {
                    CI_ResponsibleParty rp = new CI_ResponsibleParty();
                    object rpobj = rp;
                    PropertyInfo[] propInfo2 = rpobj.GetType().GetProperties();
                    //ToDo:  Not sure if we need an Xpath expression List, but if so, we can do that here
                    //responsiblePartySubSectionXpath = new List<string>();
                    foreach (PropertyInfo p in propInfo2)
                    {
                        if (p.Name == "dcatProgramCode")
                        {
                            //Get the programCode if it exists
                            //eg <gmd:contact xlink:title="020-072">
                            XmlNode attributeNode = n.Attributes["xlink:title"]; //subNode.Attributes["indeterminatePosition"];
                            if (attributeNode != null)
                            {
                                string pcode = (n.Attributes["xlink:title"].Value != null) ? n.Attributes["xlink:title"].Value : "";
                                p.SetValue(rp, pcode, null);
                            }
                        }
                        else
                        {
                            //string childNodeXpath = ".";  //Use StringBuilder for loops
                            StringBuilder childNodeXpath = new StringBuilder();
                            childNodeXpath.Append(".");

                            string[] splitby = new string[] { "__" };
                            string[] nameParts = p.Name.Split(splitby, StringSplitOptions.RemoveEmptyEntries);
                            foreach (string entry in nameParts)
                            {
                                //childNodeXpath += "/*[local-name()='" + entry + "']";
                                childNodeXpath.Append("/*[local-name()='" + entry + "']");
                            }
                            //responsiblePartySubSectionXpath.Add(childNodeXpath); //Adding the Xpath to list for later use                    
                            //Console.WriteLine(childNodeXpath.ToString());
                            string nodeValue =
                                (n.FirstChild.SelectSingleNode(childNodeXpath.ToString()) != null) ?
                                n.FirstChild.SelectSingleNode(childNodeXpath.ToString()).InnerText : "";
                            p.SetValue(rp, nodeValue, null);
                        }
                    }
                    //contactRpSection.Add(rp);
                    rpList.Add(rp);
                }
            }
            return rpList;
        }
        private void returnMD_DistributionSection()
        {
            _distributionInfo__MD_Distribution = new List<MD_Distributor>();
            //MD_Distributor mdDistributor = new MD_Distributor();            
            //MD_StandardOrderProcess mdSOP = new MD_StandardOrderProcess();
            //MD_Format mdFormat = new MD_Format();
            //MD_DigitalTransferOptions mdDigiTransfer = new MD_DigitalTransferOptions();
            
            //gmi:MI_Metadata/gmd:distributionInfo/gmd:MD_Distribution/gmd:distributor //list of distributors
                   //gmd:MD_Distributor/gmd:distributorContact //only 1
                   //gmd:MD_Distributor/gmd:distributionOrderProcess/MD_StandardOrderProcess  //NodeList
                   //gmd:MD_Distributor/gmd:distributorFormat/gmd:MD_Format  //NodeList
                   //gmd:MD_Distributor/gmd:distributorTransferOptions/gmd:MD_DigitalTransferOptions //NodeList

            //ToDo: This assumes all elments are nested under the distributor element.  Need to handle exceptions to this when
            //a section might have content outside the distributor.  For now we force the content to be a sibling of the distributor

            XmlNode nodeToDelete = inboundMetadataRecordSkippedElements.DocumentElement.SelectSingleNode("./*[local-name()='distributionInfo']");
            if (nodeToDelete != null)
            {
                nodeToDelete.RemoveAll();
                removeEmptyParentNodes(nodeToDelete);
            }

 
            XmlNodeList distInfoMD_DistributorSection = inboundMetadataRecord.DocumentElement.SelectNodes(IsoNodeXpaths.distributionInfo__MD_DistributionXpath);
            foreach (XmlNode gmddistributor in distInfoMD_DistributorSection)
            {
                //Create a key,value pair to get to each child node
                MD_Distributor mdDistributor = new MD_Distributor();
                object distRP = mdDistributor;

                List<KeyValuePair<string, string>> kvList = extractPartentXmlElementNameFromClass(distRP);
                //for (int i = 0; i < kvList.Count; i++)
                //{
                //    Console.WriteLine("Key " + kvList[i].Key.ToString()
                //        + "  Value: " + kvList[i].Value.ToString());
                //}
                                                 
                //string pname = "distributorContact__CI_ResponsibleParty";
                string pname = "distributorContact";
                KeyValuePair<string, string> kv = kvList.Find(delegate(KeyValuePair<string, string> kv1) { return kv1.Key == pname; });

                XmlNode contactInfo = gmddistributor.SelectSingleNode("."+kv.Value);
                if (contactInfo != null)
                {
                    if (contactInfo.HasChildNodes)
                    {
                        //mdDistributor.distributorContact__CI_ResponsibleParty =
                        object ciRP = new CI_ResponsibleParty();
                        extractXmlContentwReflection(ref ciRP, contactInfo.FirstChild);
                        mdDistributor.distributorContact = (CI_ResponsibleParty)ciRP;
                    }                    
                }

                pname = "distributionOrderProcess__MD_StandardOrderProcess";
                kv = kvList.Find(delegate(KeyValuePair<string, string> kv1){ return kv1.Key == pname; });
                XmlNodeList mdSOPList = gmddistributor.SelectNodes("." + kv.Value);
                if (mdSOPList != null)
                {                    
                    
                    foreach (XmlNode mdSOPnode in mdSOPList)
                    {
                        object mdSOP = new MD_StandardOrderProcess();
                        extractXmlContentwReflection(ref mdSOP, mdSOPnode);
                        mdDistributor.distributionOrderProcess__MD_StandardOrderProcess.Add((MD_StandardOrderProcess)mdSOP);
                    }
                    
                }
                pname = "distributorFormat__MD_Format";
                kv = kvList.Find(delegate(KeyValuePair<string, string> kv1) { return kv1.Key == pname; });
                XmlNodeList mdFormatList = gmddistributor.SelectNodes("." + kv.Value);
                if (mdFormatList != null)
                {
                    foreach (XmlNode mdFormatNode in mdFormatList)
                    {
                        object mdFormat = new MD_Format();
                        extractXmlContentwReflection(ref mdFormat, mdFormatNode);
                        mdDistributor.distributorFormat__MD_Format.Add((MD_Format)mdFormat);
                    }
                }

                pname = "distributorTransferOptions__MD_DigitalTransferOptions";
                kv = kvList.Find(delegate(KeyValuePair<string, string> kv1) { return kv1.Key == pname; });
                XmlNodeList mdDigiTransferList = gmddistributor.SelectNodes("." + kv.Value);
                if (mdDigiTransferList != null)
                {
                    foreach (XmlNode mdDigiTransferNode in mdDigiTransferList)
                    {
                        object mdDigiTransferOption = new MD_DigitalTransferOptions();
                        extractXmlContentwReflection(ref mdDigiTransferOption, mdDigiTransferNode);
                        mdDistributor.distributorTransferOptions__MD_DigitalTransferOptions.Add((MD_DigitalTransferOptions)mdDigiTransferOption);
                    }
                }

                //object distRPobj = distRP;
                //extractXmlContentwReflection(ref distRP, gmddistributor);
                //mdDistributor.distributorContact__CI_ResponsibleParty = distRP as CI_ResponsibleParty;

                _distributionInfo__MD_Distribution.Add(mdDistributor);
            }
            //Check for distribution format and transfer options not under distributor and place under an empty Distributor
            MD_Distributor extraDistributor = new MD_Distributor();
            XmlNodeList distFormatList = inboundMetadataRecord.DocumentElement.SelectNodes(
                "./*[local-name()='distributionInfo']/*[local-name()='MD_Distribution']/*[local-name()='distributionFormat']/*[local-name()='MD_Format']");
            if (distFormatList != null)
            {                
                foreach (XmlNode distFormatNode in distFormatList)
                {
                    object distFormat = new MD_Format();
                    extractXmlContentwReflection(ref distFormat, distFormatNode);
                    extraDistributor.distributorFormat__MD_Format.Add((MD_Format)distFormat);
                }
            }
            XmlNodeList transferOptionsList = inboundMetadataRecord.DocumentElement.SelectNodes(
                "./*[local-name()='distributionInfo']/*[local-name()='MD_Distribution']/*[local-name()='transferOptions']/*[local-name()='MD_DigitalTransferOptions']");
            if (transferOptionsList != null)
            {
                foreach (XmlNode transferOptionsNode in transferOptionsList)
                {
                    object transferOption = new MD_DigitalTransferOptions();
                    extractXmlContentwReflection(ref transferOption, transferOptionsNode);
                    extraDistributor.distributorTransferOptions__MD_DigitalTransferOptions.Add((MD_DigitalTransferOptions)transferOption);
                }
            }
            if (extraDistributor.distributorFormat__MD_Format.Count > 0 || extraDistributor.distributorTransferOptions__MD_DigitalTransferOptions.Count > 0)
            {
                extraDistributor.distributorContact.individualName = "Content Missing, Add A Contact";
                extraDistributor.distributorContact.role = "distributor";
                _distributionInfo__MD_Distribution.Add(extraDistributor);
            }           
           
            
        }
        /// <summary>
        /// Returns the xpath expression based on the structure of class property names.
        /// </summary>
        /// <param name="classToParseXmlParentNodeList"></param>
        /// <returns></returns>
        private List<KeyValuePair<string,string>> extractPartentXmlElementNameFromClass(object classToParseXmlParentNodeList)
        {
            List<KeyValuePair<string, string>> tempList = new List<KeyValuePair<string,string>>();
            object rpobj = classToParseXmlParentNodeList;
            string className = "/*[local-name()='" + rpobj.GetType().Name.ToString() + "']";

            PropertyInfo[] propInfo2 = rpobj.GetType().GetProperties();            
            foreach (PropertyInfo p in propInfo2)
            {                
                StringBuilder childNodeXpath = new StringBuilder();
                //childNodeXpath.Append("." + className);
                childNodeXpath.Append(className);
                string[] splitby = new string[] { "__" };
                string[] nameParts = p.Name.Split(splitby, StringSplitOptions.RemoveEmptyEntries);
                foreach (string entry in nameParts)
                {                    
                    childNodeXpath.Append("/*[local-name()='" + entry + "']");
                }                
                tempList.Add(new KeyValuePair<string, string>(p.Name, childNodeXpath.ToString()));  
                //Console.WriteLine(p.Name +"  " + childNodeXpath.ToString());
                
            }         


            return tempList;
        }
        private void extractXmlContentwReflection(ref object classToParseXmlNodeList, XmlNode nodeToParseIntoClass)
        {
            XmlNode n = nodeToParseIntoClass;
           
            object rpobj = classToParseXmlNodeList;
            //string className = "/*[local-name()='" + rpobj.GetType().Name.ToString() + "']";

            PropertyInfo[] propInfo2 = rpobj.GetType().GetProperties();
            //ToDo:  Not sure if we need an Xpath expression List, but if so, we can do that here
            //responsiblePartySubSectionXpath = new List<string>();
            foreach (PropertyInfo p in propInfo2)
            {
                //string childNodeXpath = ".";  //Use StringBuilder for loops
                StringBuilder childNodeXpath = new StringBuilder();
                childNodeXpath.Append("."); //+ className);

                string[] splitby = new string[] { "__" };
                string[] nameParts = p.Name.Split(splitby, StringSplitOptions.RemoveEmptyEntries);
                foreach (string entry in nameParts)
                {
                    //childNodeXpath += "/*[local-name()='" + entry + "']";
                    childNodeXpath.Append("/*[local-name()='" + entry + "']");
                }
                //responsiblePartySubSectionXpath.Add(childNodeXpath); //Adding the Xpath to list for later use                    
                //Console.WriteLine(childNodeXpath.ToString());
                string nodeValue =
                    (n.SelectSingleNode(childNodeXpath.ToString()) != null) ?
                    n.SelectSingleNode(childNodeXpath.ToString()).InnerText : "";
                //p.SetValue(rp, nodeValue, null);
                p.SetValue(classToParseXmlNodeList, nodeValue, null);
            }                
        }

        public XmlDocument saveChangestoRecord(string outboundMetadataRecordFormatName)        
        {
            //Call private method to set each element value back into the target record
            //ToDo:  Create an outbound record that is a copy of inbound record, but with the modified sections.

            //Depending on the format detected, load the correct template record to for the outgoing metadata record
            //(gmd:MD_Metdata = 19115, gmi:MI_Metadata = 19115-2; metadata = both CSDGM and ArcGIS)
            
            templateMetadataRecord = new XmlDocument();
            if (outboundMetadataRecordFormatName == "ISO19115-2") //(inboundMetadataFormat == "ISO19115-2")
            {
                templateMetadataRecord.Load(Utils1.EmeUserAppDataFolder + "\\Eme4xSystemFiles\\EMEdb\\MItemplate.xml");
            }
            else if (outboundMetadataRecordFormatName == "ISO19115") //(inboundMetadataFormat == "ISO19115")
            {
                templateMetadataRecord.Load(Utils1.EmeUserAppDataFolder + "\\Eme4xSystemFiles\\EMEdb\\MDtemplate.xml");
            }
            else
            {
                //do something; not sure what yet  :-)
            }
            
            constructMI_MetadataMarkUp();
            
            return outboundMetadataRecord;
            //outboundMetadataRecord.Save(@"C:\Users\dspinosa\Desktop\testMetadata\DCAT\testCommonCoreRecordFromGeoportal-2vJUNK.xml");
            //outboundMetadataRecord.Save(           
            
        }

        private void setISONameSpaceManager()
        {
            //These are the schemaset.schemas.targetNamespaces
            //http://www.isotc211.org/2005/gmi
            //http://www.isotc211.org/2005/gco
            //http://www.opengis.net/gml/3.2
            //http://www.w3.org/1999/xlink
            //http://www.isotc211.org/2005/gmd
            //http://www.isotc211.org/2005/gss
            //http://www.isotc211.org/2005/gts
            //http://www.isotc211.org/2005/gsr
            //http://www.isotc211.org/2005/gmd
            //http://www.isotc211.org/2005/gmd
            //http://www.isotc211.org/2005/gmx
            //http://www.isotc211.org/2005/srv

            //string validationXSD = @"http://www.isotc211.org/2005/gmi/gmi.xsd";
            //string validationXSD = @"http://www.ngdc.noaa.gov/metadata/published/xsd/schema.xsd";
            //string validationXSD = @"http://www.isotc211.org/2005/gmd/gmd.xsd";

            string validationXSD = Utils1.EmeUserAppDataFolder + "\\Eme4xSystemFiles\\MetadataSchema\\NOAA_19115_2\\schema.xsd";
            XmlReaderSettings readerSettings = new XmlReaderSettings();
            readerSettings.IgnoreComments = true;
            XmlSchema xs = XmlSchema.Read(XmlReader.Create(validationXSD, readerSettings), null);
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.ValidationEventHandler += new ValidationEventHandler(ValidationCallback);
            schemaSet.Add(xs);
            schemaSet.Compile();
                        
            NameTable nt = new NameTable();
            isoNsManager = new XmlNamespaceManager(nt);
            isoNsManager.AddNamespace("gco", "http://www.isotc211.org/2005/gco");
            isoNsManager.AddNamespace("gfc", "http://www.isotc211.org/2005/gfc");
            isoNsManager.AddNamespace("gmd", "http://www.isotc211.org/2005/gmd");
            isoNsManager.AddNamespace("gmi", "http://www.isotc211.org/2005/gmi");
            isoNsManager.AddNamespace("gml", "http://www.isotc211.org/2005/gml");
            isoNsManager.AddNamespace("gmx", "http://www.isotc211.org/2005/gmx");
            isoNsManager.AddNamespace("grg", "http://www.isotc211.org/2005/grg");
            isoNsManager.AddNamespace("gsr", "http://www.isotc211.org/2005/gsr");
            isoNsManager.AddNamespace("gss", "http://www.isotc211.org/2005/gss");
            isoNsManager.AddNamespace("gts", "http://www.isotc211.org/2005/gts");
            isoNsManager.AddNamespace("xlink", "http://www.isotc211.org/2005/xlink");
           

        }

        private void constructMI_MetadataMarkUp()
        {
            //Make sure the Record has each section, and in the required order
            //Re-construct entire XML document to ensure proper structure
            //Document order determined by template Metadata record.  Each main section will be stubbed in
            outboundMetadataRecord = new XmlDocument();
            //outboundMetadataRecord.PreserveWhitespace = false;
            
            
            //Clone Node From Template; then insert into outgoing XmlDoc
            XmlNode templateRecordRoot = templateMetadataRecord.DocumentElement;            
            XmlNode clonedNode = templateRecordRoot.CloneNode(false);
            XmlNode cloneImport = outboundMetadataRecord.ImportNode(clonedNode, true);
            outboundMetadataRecord.AppendChild(cloneImport);

            ////Having Strange problems when I insert the xmlDeclaration.  Leaving it out for now.
            ////Might need to create and ignore BOM
            //XmlDeclaration xdec = outboundMetadataRecord.CreateXmlDeclaration("1.0","UTF-8", null);                        
            //XmlElement xEml = outboundMetadataRecord.DocumentElement;
            //outboundMetadataRecord.InsertBefore(xdec, xEml);
            
            #region Code to create empty shell of Iso record
            XmlNodeList nodelist = templateMetadataRecord.DocumentElement.ChildNodes;
            foreach (XmlNode n in nodelist)
            {
                Console.WriteLine(n.Name);
                XmlNode cloneCurrentTemplateNode = n.SelectSingleNode(".").CloneNode(false);
                XmlNode importThisNode = outboundMetadataRecord.ImportNode(cloneCurrentTemplateNode, false);
                outboundMetadataRecord.DocumentElement.AppendChild(importThisNode);
            }
            XmlNodeList commentSections = outboundMetadataRecord.SelectNodes("//comment()");
            for (int i = commentSections.Count - 1; i >= 0; i--)
            {
                commentSections[i].ParentNode.RemoveChild(commentSections[i]);
            }
            //THe above gives an empty child node under the root node for each major section within the template.
            //Start inserting each of the corresponding child nodes from here.  When there are null values, some nodes should always remain in outgoing
            //xml document while others should be removed.
            #endregion
            
            //Section 1
            constructChildNodeUnderParent(outboundMetadataRecord.DocumentElement, IsoNodeXpaths.fileIdentifierXpath, fileid, false, true, true);

            //Section 2
            constructChildNodeUnderParent(outboundMetadataRecord.DocumentElement, IsoNodeXpaths.languageXpath, _language, false, true, true);

            //Section 3
            constructChildNodeUnderParent(outboundMetadataRecord.DocumentElement, "./*[local-name()='characterSet']", null, false, true, true);            
            
            //Section 5
            constructChildNodeUnderParent(outboundMetadataRecord.DocumentElement, IsoNodeXpaths.hierarchyLevel_MD_ScopeCodeXpath, hyLevel_md_scopeCode, true, true, true);
            
            //Section 7, contact, Required  Should be at least one contact section in the outgoing document
            if (_contactRpSection != null)
            {
                if (_contactRpSection.Count > 0)
                {
                    constructCI_ResponsiblePartyMarkUp(_contactRpSection, IsoNodeXpaths.contact_CI_ResponsiblePartyXpath);
                }
                else
                {
                    //add the attribute gco:nilReason="missing"

                    XmlAttribute nilReasonAttribute = outboundMetadataRecord.CreateAttribute("gco", "nilReason", "http://www.isotc211.org/2005/gco");
                    nilReasonAttribute.Value = "missing";
                    XmlAttributeCollection ac = outboundMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.contact_CI_ResponsiblePartyXpath).Attributes;
                    ac.Append(nilReasonAttribute);
                    //responsiblePartySectionTemplate.Attributes;
                    //ac.Append(pcodeAttribut);
                }
            }
            //Sections 8, 9, and 10
            constructChildNodeUnderParent(outboundMetadataRecord.DocumentElement, IsoNodeXpaths.dateStampXpath, _dateStamp, false, true, true);
            constructChildNodeUnderParent(outboundMetadataRecord.DocumentElement, "./*[local-name()='metadataStandardName']",null,false,true,true);
            constructChildNodeUnderParent(outboundMetadataRecord.DocumentElement, "./*[local-name()='metadataStandardVersion']",null,false,true,true);
            
            //Section 16 identificationInfo Section:  title, abstract, purpose, keywords, etc.
            constructIdInfo_MD_DataIdentificationSection();
            
            //Section 18 distributionInfo Section

            construct_distributionInfoSection();
            
            //****************
            //Add Content Back in that is not suppored by EME.  Some sections repeat.  Insert after the last occurance of the matching
            //sibling even if it is empty.  The method after this will remove any rootChild that does not have children.  This will ensure
            //content in the correct order based on the template metadata record.
            //This method will support inserting content after metadataStandardName

            string currentNode = "";
            string nextNode = "" ;
            
            XmlNodeList rootChildNodes = outboundMetadataRecord.DocumentElement.ChildNodes;
            for (int ii = 0; ii< rootChildNodes.Count; ii++)
            //for (int ii = rootChildNodes.Count -1; ii >= 0; ii--)  //Reverse Loop
            {
                currentNode = rootChildNodes[ii].LocalName;
                nextNode = (ii < rootChildNodes.Count - 1) ? rootChildNodes[ii + 1].LocalName : "end";
                //lastNode = rootChildNodes[rootChildNodes.Count - 1].LocalName;

                if (currentNode != nextNode) //if repeated this will stop at the last position of the repeated node
                {
                    //If repeated this will stop at the last position of the repeated node.
                    //Check skipped document and insert after this position if it exists.
                    //What about the last node?!!!!!
                    string xpathForMissing = "./*[local-name()='" + currentNode + "']";
                    XmlNode outboundNodeToReplaceOrDelete = outboundMetadataRecord.DocumentElement.SelectSingleNode(xpathForMissing);
                    XmlNodeList unsupportedNodesToInsert = inboundMetadataRecordSkippedElements.DocumentElement.SelectNodes(xpathForMissing);
                    if (unsupportedNodesToInsert != null)
                    {
                        int missingNodeCount = unsupportedNodesToInsert.Count;
                        if (missingNodeCount > 0)
                        {
                            int nodePostion = 1;
                            foreach (XmlNode insertThisNode in unsupportedNodesToInsert)
                            {
                                XmlNode nodeCopy = insertThisNode.CloneNode(true);
                                XmlNode nodeImport = outboundMetadataRecord.ImportNode(nodeCopy, true);

                                //outboundNodeToReplaceOrDelete = outboundMetadataRecord.DocumentElement.SelectSingleNode(xpathForMissing);
                                XmlNode lastinsertedNodeRef = outboundMetadataRecord.DocumentElement.SelectNodes(xpathForMissing)[nodePostion - 1];
                                outboundNodeToReplaceOrDelete.ParentNode.InsertAfter(nodeImport, lastinsertedNodeRef);
                                Console.WriteLine("Inserted " + currentNode);
                                nodePostion++;                                
                                insertThisNode.RemoveAll();
                                removeEmptyParentNodes(insertThisNode);
                            }
                        }
                    }
                }

                ////Don't Delete if has the nillReason Attribute
                //XmlElement xe = (XmlElement)rootChildNodes[ii];
                //if (!xe.HasAttributes)
                //{
                //    if (rootChildNodes[ii].HasChildNodes == false)
                //    {
                //        //emptyNodes[ii].ParentNode.RemoveChild(emptyNodes[ii]); //add this back in later
                        
                //        string nodeName = rootChildNodes[ii].LocalName;
                //        //Console.WriteLine("Processing: " + nodeName);
                        
                //        //Check the skippedElements Doc and add remaining sections back int.
                //        //Some of these sections could be repeated, so need to get node list and then insert each repeated sequentially
                //        //Similar code in the CI_Responsible Party Section
                //        string xpathForMissing = "./*[local-name()='" + nodeName + "']";
                //        XmlNode outboundNodeToReplaceOrDelete = outboundMetadataRecord.DocumentElement.SelectSingleNode(xpathForMissing);
                //        XmlNodeList unsupportedNodesToInsert = inboundMetadataRecordSkippedElements.DocumentElement.SelectNodes(xpathForMissing);
                //        if (unsupportedNodesToInsert != null)
                //        {
                //            int missingNodeCount = unsupportedNodesToInsert.Count;
                //            if (missingNodeCount > 0)
                //            {
                //                int nodePostion = 0;
                //                foreach (XmlNode insertThisNode in unsupportedNodesToInsert)
                //                {
                //                    XmlNode nodeCopy = insertThisNode.CloneNode(true);
                //                    XmlNode nodeImport = outboundMetadataRecord.ImportNode(nodeCopy, true);
                //                    if (nodePostion == 0)
                //                    {
                //                        //Replace the first occurance
                //                        outboundNodeToReplaceOrDelete.ParentNode.ReplaceChild(nodeImport, outboundNodeToReplaceOrDelete);
                //                    }
                //                    else
                //                    {
                //                        //Append additional
                //                        outboundNodeToReplaceOrDelete = outboundMetadataRecord.DocumentElement.SelectSingleNode(xpathForMissing);
                //                        XmlNode lastinsertedNodeRef = outboundMetadataRecord.DocumentElement.SelectNodes(xpathForMissing)[nodePostion - 1];

                //                        outboundNodeToReplaceOrDelete.ParentNode.InsertAfter(nodeImport, lastinsertedNodeRef);
                //                    }
                //                    nodePostion++;
                //                    //inboundMetadataRecordSkippedElements.DocumentElement(sel
                //                    insertThisNode.RemoveAll();
                //                    removeEmptyParentNodes(insertThisNode);
                //                }                                
                //            }
                //            else
                //            {
                //                rootChildNodes[ii].ParentNode.RemoveChild(rootChildNodes[ii]); //add this back in later
                //            }
                //        }
                //        else
                //        {
                //            rootChildNodes[ii].ParentNode.RemoveChild(rootChildNodes[ii]); //add this back in here
                //        }
                //    }
                //}
            }

            //****************
            //Clean up the document and remove empty nodes under the root node.  Note, this loop run backwards.
            XmlNodeList emptyNodes = outboundMetadataRecord.DocumentElement.ChildNodes;
            for (int ii = emptyNodes.Count - 1; ii >= 0; ii--)
            {
                //Don't Delete if has the nillReason Attribute, or any kind of attribute since EME or unsupported 
                //elements may contain them.
                XmlElement xe = (XmlElement)emptyNodes[ii];
                if (!xe.HasAttributes)
                {
                    if (emptyNodes[ii].HasChildNodes == false)
                    {
                        emptyNodes[ii].ParentNode.RemoveChild(emptyNodes[ii]);
                    }
                }
            }
            
            
            //****************
            //Method to remove all child/parent nodes that containt the phrase *template*
            XmlNodeList nodesToRemove = outboundMetadataRecord.DocumentElement.SelectNodes("//*[text()='*template*']");
            int countofNodes = nodesToRemove.Count;
            foreach (XmlNode removeMe in nodesToRemove)
            {
                removeMe.RemoveAll();
                removeEmptyParentNodes(removeMe);
            }

            //outboundMetadataRecord.PreserveWhitespace = false;            
            ////Used this to insert the XML Declaration without BOM (byte order mark)
            //XmlTextWriter xw = new XmlTextWriter(@"C:\Data\EME\testWriteMetaData\testCommonCoreRecordFromGeoportal-2vJUNK.xml", new UTF8Encoding(false));
            //xw.Formatting = Formatting.Indented;
            //outboundMetadataRecord.Save(xw);
            
        }

        
        
        private void constructIdInfo_MD_DataIdentificationSection()
        {
            //Build this section in order.  Leave out elements that are not required if no content                        
            //Clone the MD_DataIdentification and insert and then start appending each subsection
            //identificationInfo/MD_DataIdentification | SV_ServiceIdentification (inherit and extend MD_Data???)

            string MD_dataInfoNodeXpath ="./*[local-name()='identificationInfo']/*[local-name()='MD_DataIdentification']";
            constructChildNodeUnderParent(
                outboundMetadataRecord.DocumentElement.SelectSingleNode("./*[local-name()='identificationInfo']"),
                MD_dataInfoNodeXpath, null, false, false, false);
            
            //Work from this node and insert each section
            XmlNode outbound_md_DataIdSection = outboundMetadataRecord.DocumentElement.SelectSingleNode(MD_dataInfoNodeXpath);

            //CI_Citation package needs insertion, then each sub element
            #region CI_Citation Package 16.1

            string citationXpath = "./*[local-name()='identificationInfo']/*[local-name()='MD_DataIdentification']/*[local-name()='citation']";
            string citationCIpackageXpath = citationXpath + "/*[local-name()='CI_Citation']";             
            //constructChildNodeUnderParent(outbound_md_DataIdSection, citationXpath, null, false, true, false);            
            constructChildNodeUnderParent(outbound_md_DataIdSection, citationXpath, null, false, false, false);
            constructChildNodeUnderParent(outbound_md_DataIdSection.FirstChild, citationCIpackageXpath , null, false, false, false);
            //outboundMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.idInfo_citation_TitleXpath).FirstChild.InnerText = _idInfo_citation_title;
            XmlNode citationCiSectionNode = outboundMetadataRecord.DocumentElement.SelectSingleNode(citationCIpackageXpath);

            //Section 16.1.1 Title (Required)
            constructChildNodeUnderParent(citationCiSectionNode,IsoNodeXpaths.idInfo_citation_TitleXpath, _idInfo_citation_title, false, true, false);

            //Section 16.1.2 alternateTitle 0..*
            XmlNodeList altTitleNL = inboundMetadataRecordSkippedElements.DocumentElement.SelectNodes(citationCIpackageXpath + "/*[local-name()='alternateTitle']");
            if (altTitleNL != null)
            {
                foreach (XmlNode altTitle in altTitleNL)
                {
                    constructChildNodeUnderParent(citationCiSectionNode, altTitle, true);
                    altTitle.RemoveAll();
                    removeEmptyParentNodes(altTitle);
                }
            }
            
            //Section 16.1.3 Date (Required)  Contains both Date and DateType Codelist (CI_DateTypeCode)
            //Providing support for up to three occurances even though the standard does not specify a max
            string idInfoCI_CitationDateXpath =
                "./*[local-name()='identificationInfo']/*[local-name()='MD_DataIdentification']/*[local-name()='citation']/*[local-name()='CI_Citation']/*[local-name()='date']";
            //ToDo: Maybe make an additional table of Xpath for key template nodes????
            if (string.IsNullOrEmpty(_idInfo_citation_date_creation) != true)
            {
                construct_CI_DateSection(citationCiSectionNode, _idInfo_citation_date_creation, "creation", idInfoCI_CitationDateXpath);
            }
            if (string.IsNullOrEmpty(_idInfo_citation_date_publication) != true)
            {
                construct_CI_DateSection(citationCiSectionNode, _idInfo_citation_date_publication, "publication", idInfoCI_CitationDateXpath);
            }
            if (string.IsNullOrEmpty(_idInfo_citation_date_revision) != true)
            {
                construct_CI_DateSection(citationCiSectionNode, _idInfo_citation_date_revision, "revision", idInfoCI_CitationDateXpath);
            }
            
            //Section 16.1.4 edition 0..1
            XmlNode ciEdition = inboundMetadataRecordSkippedElements.DocumentElement.SelectSingleNode(citationCIpackageXpath + "/*[local-name()='edition']");
            if (ciEdition != null)
            {
                constructChildNodeUnderParent(citationCiSectionNode, ciEdition, true);
                ciEdition.RemoveAll();
                removeEmptyParentNodes(ciEdition);
            }

            //Section 16.1.5 edtionDate 0..1
            XmlNode ciEditionDate = inboundMetadataRecordSkippedElements.DocumentElement.SelectSingleNode(citationCIpackageXpath + "/*[local-name()='editionDate']");
            if (ciEditionDate != null)
            {
                constructChildNodeUnderParent(citationCiSectionNode, ciEditionDate, true);
                ciEditionDate.RemoveAll();
                removeEmptyParentNodes(ciEditionDate);
            }

            //Section 16.1.6 identifier 0..*
            XmlNodeList ciIDnl = inboundMetadataRecordSkippedElements.DocumentElement.SelectNodes(citationCIpackageXpath + "/*[local-name()='identifier']");
            foreach (XmlNode ciID in ciIDnl)
            {
                constructChildNodeUnderParent(citationCiSectionNode, ciID, true);
                ciID.RemoveAll();
                removeEmptyParentNodes(ciID);
            }   

            //Section 16.1.7 citedResponsibleParty
            if (idInfo_citation_citedResponsibleParty != null)
            {
                if (idInfo_citation_citedResponsibleParty.Count > 0)
                {
                    //Must first insert the very first instance.  Other occurances will be inserted after the first item in the list.
                    constructChildNodeUnderParent(citationCiSectionNode, IsoNodeXpaths.idInfo_citation_citedResponsiblePartyXpath, null, false, true, false);
                    constructCI_ResponsiblePartyMarkUp(idInfo_citation_citedResponsibleParty, IsoNodeXpaths.idInfo_citation_citedResponsiblePartyXpath);
                }
            }
                                    
            //Process any other possible other CI_Citation elements not supported by EME and insert after citedResponsibleParty
            XmlNodeList skippedCitationElements = inboundMetadataRecordSkippedElements.DocumentElement.SelectNodes(citationCIpackageXpath+"/child::node()");            
            if (skippedCitationElements != null)
            {
                if (skippedCitationElements.Count > 0)
                {
                    foreach (XmlNode otherCitationElement in skippedCitationElements)
                    {
                        constructChildNodeUnderParent(citationCiSectionNode, otherCitationElement, true);
                        otherCitationElement.RemoveAll();
                        removeEmptyParentNodes(otherCitationElement);
                    }
                }
            }
            #endregion
            

            //Section 16.2 Abstract (required)
            constructChildNodeUnderParent(outbound_md_DataIdSection, IsoNodeXpaths.idInfo_AbstractXpath, _idInfo_abstract,false, true, false);
            
            //Section 16.3 Purpose (optional)
            
            if (string.IsNullOrEmpty(_idInfo_purpose) != true)
            {
                constructChildNodeUnderParent(outbound_md_DataIdSection, IsoNodeXpaths.idInfo_PurposeXpath, _idInfo_purpose, false, true, false);
            }

            //Section 16.4 Credit 0..*
            XmlNodeList idInfoCredit = inboundMetadataRecordSkippedElements.DocumentElement.SelectNodes(MD_dataInfoNodeXpath + "/*[local-name()='credit']");
            foreach (XmlNode skippedNode in idInfoCredit)
            {
                constructChildNodeUnderParent(outbound_md_DataIdSection, skippedNode, true);
                skippedNode.RemoveAll();
                removeEmptyParentNodes(skippedNode);
            }  


            //Section 16.5 Status (optional)
            if (string.IsNullOrEmpty(_idInfo_status_MD_ProgressCode) !=true)
            {
                constructChildNodeUnderParent(outbound_md_DataIdSection, IsoNodeXpaths.idInfo_Status_MD_ProgressCodeXpath, _idInfo_status_MD_ProgressCode, true, true, false);
            }

            //Section 16.6 Point of Contact aka Owner of the data
            if (idInfo_pointOfContact != null)
            {
                if (idinfoPointOfContact.Count > 0)
                {
                    constructChildNodeUnderParent(outbound_md_DataIdSection, IsoNodeXpaths.idInfo_pointOfContactXpath, null, false, false, false);
                    constructCI_ResponsiblePartyMarkUp(idinfoPointOfContact, IsoNodeXpaths.idInfo_pointOfContactXpath);
                }
            }

            //Section 16.7.1 resourceMaintenance (optional)  !!!!Only Section 1
            if (string.IsNullOrEmpty(_idInfo_resourceMaintenance) != true)
            {
                string resMaintNodeXpath = "./*[local-name()='identificationInfo']/*[local-name()='MD_DataIdentification']/*[local-name()='resourceMaintenance']";
                // ./*[local-name()='identificationInfo']/*[local-name()='MD_DataIdentification']/*[local-name()='resourceMaintenance']/*[local-name()='MD_MaintenanceInformation']
                XmlNode tempNode = templateMetadataRecord.DocumentElement.SelectSingleNode(resMaintNodeXpath);                
                constructChildNodeUnderParent(outbound_md_DataIdSection, tempNode, true);
                XmlNode tempResMaintNode = outboundMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.idInfo_resourceMaintenanceXpath);
                constructChildNodeUnderParent(tempResMaintNode, IsoNodeXpaths.idInfo_resourceMaintenanceXpath, _idInfo_resourceMaintenance, true, true,true);
            }

            //Section 16.7 resourceMaintenance from SkippedDoc.  Insert after 16.7.1  0..*            
            XmlNodeList resMaint = inboundMetadataRecordSkippedElements.DocumentElement.SelectNodes(MD_dataInfoNodeXpath + "/*[local-name()='resourceMaintenance']");
            foreach (XmlNode skippedNode in resMaint)
            {
                constructChildNodeUnderParent(outbound_md_DataIdSection, skippedNode, true);
                skippedNode.RemoveAll();
                removeEmptyParentNodes(skippedNode);
            }

            //Section 16.8 graphicOverview from SkippedDoc.  0..*            
            XmlNodeList graphOv = inboundMetadataRecordSkippedElements.DocumentElement.SelectNodes(MD_dataInfoNodeXpath + "/*[local-name()='graphicOverview']");
            foreach (XmlNode skippedNode in graphOv)
            {
                constructChildNodeUnderParent(outbound_md_DataIdSection, skippedNode, true);
                skippedNode.RemoveAll();
                removeEmptyParentNodes(skippedNode);
            }

            //Section 16.9 resourceFormat from SkippedDoc.  0..*            
            XmlNodeList resourceFm = inboundMetadataRecordSkippedElements.DocumentElement.SelectNodes(MD_dataInfoNodeXpath + "/*[local-name()='resourceFormat']");
            foreach (XmlNode skippedNode in resourceFm)
            {
                constructChildNodeUnderParent(outbound_md_DataIdSection, skippedNode, true);
                skippedNode.RemoveAll();
                removeEmptyParentNodes(skippedNode);
            }

            //Section 16.10 Descriptive Keywords
            if (kwUserList.Count > 0)
            {
                XmlNode keywordsUserFrag = constructKeywordSection(kwUserList, IsoNodeXpaths.idInfo_keywordsUserXpath);
                constructChildNodeUnderParent(outbound_md_DataIdSection, keywordsUserFrag, true);
            }

            if (kwEpaList.Count > 0)
            {
                XmlNode keywordsEpaTemplateSection = constructKeywordSection(kwEpaList, IsoNodeXpaths.idInfo_keywordsEpaXpath);
                constructChildNodeUnderParent(outbound_md_DataIdSection, keywordsEpaTemplateSection, true);
            }
            if (kwPlaceList.Count > 0)
            {
                XmlNode keywordsPlaceFrag = constructKeywordSection(kwPlaceList, IsoNodeXpaths.idInfo_keywordsPlaceXpath);
                constructChildNodeUnderParent(outbound_md_DataIdSection, keywordsPlaceFrag, true);
            }

            //Section 16.10 Keyword Section from SkippedDoc.  0..*            
            XmlNodeList otherKeyWords = inboundMetadataRecordSkippedElements.DocumentElement.SelectNodes(MD_dataInfoNodeXpath + "/*[local-name()='descriptiveKeywords']");
            foreach (XmlNode skippedNode in otherKeyWords)
            {
                constructChildNodeUnderParent(outbound_md_DataIdSection, skippedNode, true);
                skippedNode.RemoveAll();
                removeEmptyParentNodes(skippedNode);
            }
            
            //Section 16.11 resourceSpecificUsage Section from SkippedDoc.  0..*            
            XmlNodeList resUsage = inboundMetadataRecordSkippedElements.DocumentElement.SelectNodes(MD_dataInfoNodeXpath + "/*[local-name()='resourceSpecificUsage']");
            foreach (XmlNode skippedNode in resUsage)
            {
                constructChildNodeUnderParent(outbound_md_DataIdSection, skippedNode, true);
                skippedNode.RemoveAll();
                removeEmptyParentNodes(skippedNode);
            }

            //Section 16.12 resourceConstraints (optional)

            #region 16.12 in EME

            //MD_Constraints
            if (!string.IsNullOrEmpty(_idInfo_resourceConstraints_MD_Constraints_useLimitation))
            {
                constructChildNodeUnderParent(outbound_md_DataIdSection,
                    IsoNodeXpaths.idInfo_resourceConstraints_MD_Constraints_useLimitationXpath + "/../..",
                    null, false, true, false);
                outboundMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.idInfo_resourceConstraints_MD_Constraints_useLimitationXpath).FirstChild.InnerText =
                    _idInfo_resourceConstraints_MD_Constraints_useLimitation;
            }

            //MD_LegalConstraints:  If any one has a value then populate the section
            if (!string.IsNullOrEmpty(_idInfo_resourceConstraints_MD_LegalConstraints_useLimitation)
                | !string.IsNullOrEmpty(_idInfo_resourceConstraints_MD_LegalConstraints_accessConstraints)
                | !string.IsNullOrEmpty(_idInfo_resourceConstraints_MD_LegalConstraints_useConstraints)
                | !string.IsNullOrEmpty(_idInfo_resourceConstraints_MD_LegalConstraints_otherConstraints))
            {
                //clone the entire section *template* sections removed later
                constructChildNodeUnderParent(outbound_md_DataIdSection,
                    IsoNodeXpaths.idInfo_resourceConstraints_MD_LegalConstraints_useLimitationXpath + "/../..",
                    null, false, true, false);
                if (!string.IsNullOrEmpty(_idInfo_resourceConstraints_MD_LegalConstraints_useLimitation))
                {
                    outboundMetadataRecord.DocumentElement.SelectSingleNode
                        (IsoNodeXpaths.idInfo_resourceConstraints_MD_LegalConstraints_useLimitationXpath).FirstChild.InnerText =
                        _idInfo_resourceConstraints_MD_LegalConstraints_useLimitation;
                }
                if (!string.IsNullOrEmpty(_idInfo_resourceConstraints_MD_LegalConstraints_accessConstraints))//CodeList
                {
                    outboundMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.idInfo_resourceConstraints_MD_LegalConstraints_accessConstraintsXpath).
                        FirstChild.InnerText = _idInfo_resourceConstraints_MD_LegalConstraints_accessConstraints;
                    outboundMetadataRecord.DocumentElement.SelectSingleNode(
                        IsoNodeXpaths.idInfo_resourceConstraints_MD_LegalConstraints_accessConstraintsXpath).FirstChild.Attributes["codeListValue"].Value =
                        _idInfo_resourceConstraints_MD_LegalConstraints_accessConstraints;
                }
                if (!string.IsNullOrEmpty(_idInfo_resourceConstraints_MD_LegalConstraints_useConstraints))//CodeList
                {
                    outboundMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.idInfo_resourceConstraints_MD_LegalConstraints_useConstraintsXpath).
                        FirstChild.InnerText = _idInfo_resourceConstraints_MD_LegalConstraints_useConstraints;
                    outboundMetadataRecord.DocumentElement.SelectSingleNode(
                        IsoNodeXpaths.idInfo_resourceConstraints_MD_LegalConstraints_useConstraintsXpath).FirstChild.Attributes["codeListValue"].Value =
                        _idInfo_resourceConstraints_MD_LegalConstraints_useConstraints;
                }
                if (!string.IsNullOrEmpty(_idInfo_resourceConstraints_MD_LegalConstraints_otherConstraints))
                {
                    outboundMetadataRecord.DocumentElement.SelectSingleNode
                        (IsoNodeXpaths.idInfo_resourceConstraints_MD_LegalConstraints_otherConstraintsXpath).FirstChild.InnerText =
                        _idInfo_resourceConstraints_MD_LegalConstraints_otherConstraints;
                }
            }

            //MD_SecurityConstraints   If any one has a value then populate the section
            if (!string.IsNullOrEmpty(_idInfo_resourceConstraints_MD_SecurityConstraints_useLimitation)
                | !string.IsNullOrEmpty(_idInfo_resourceConstraints_MD_SecurityConstraints_classification)
                | !string.IsNullOrEmpty(_idInfo_resourceConstraints_MD_SecurityConstraints_userNote)
                | !string.IsNullOrEmpty(_idInfo_resourceConstraints_MD_SecurityConstraints_classificationSystem)
                | !string.IsNullOrEmpty(_idInfo_resourceConstraints_MD_SecurityConstraints_handlingDescription)
                )
            {                
                //clone the entire section *template* sections removed later
                constructChildNodeUnderParent(outbound_md_DataIdSection,
                    IsoNodeXpaths.idInfo_resourceConstraints_MD_SecurityConstraints_useLimitationXpath + "/../..",
                    null, false, true, false);

                if (!string.IsNullOrEmpty(_idInfo_resourceConstraints_MD_SecurityConstraints_useLimitation))                
                {
                    outboundMetadataRecord.DocumentElement.SelectSingleNode
                        (IsoNodeXpaths.idInfo_resourceConstraints_MD_SecurityConstraints_useLimitationXpath).FirstChild.InnerText =
                        _idInfo_resourceConstraints_MD_SecurityConstraints_useLimitation;
                }
                if (!string.IsNullOrEmpty(_idInfo_resourceConstraints_MD_SecurityConstraints_classification))  //Required and is a codeList
                {
                    outboundMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.idInfo_resourceConstraints_MD_SecurityConstraints_classificationXpath)
                        .FirstChild.InnerText = _idInfo_resourceConstraints_MD_SecurityConstraints_classification;
                    outboundMetadataRecord.DocumentElement.SelectSingleNode(
                        IsoNodeXpaths.idInfo_resourceConstraints_MD_SecurityConstraints_classificationXpath).FirstChild.Attributes["codeListValue"].Value =
                        _idInfo_resourceConstraints_MD_SecurityConstraints_classification;
                }
                if (!string.IsNullOrEmpty(_idInfo_resourceConstraints_MD_SecurityConstraints_userNote))
                {
                    outboundMetadataRecord.DocumentElement.SelectSingleNode
                        (IsoNodeXpaths.idInfo_resourceConstraints_MD_SecurityConstraints_userNoteXpath).FirstChild.InnerText =
                        _idInfo_resourceConstraints_MD_SecurityConstraints_userNote;
                }
                if (!string.IsNullOrEmpty(_idInfo_resourceConstraints_MD_SecurityConstraints_classificationSystem))
                {
                    outboundMetadataRecord.DocumentElement.SelectSingleNode(
                        IsoNodeXpaths.idInfo_resourceConstraints_MD_SecurityConstraints_classificationSystemXpath).FirstChild.InnerText =
                        _idInfo_resourceConstraints_MD_SecurityConstraints_classificationSystem;
                }
                if (!string.IsNullOrEmpty(_idInfo_resourceConstraints_MD_SecurityConstraints_handlingDescription))
                {
                    outboundMetadataRecord.DocumentElement.SelectSingleNode(
                        IsoNodeXpaths.idInfo_resourceConstraints_MD_SecurityConstraints_handlingDescriptionXpath).FirstChild.InnerText =
                        _idInfo_resourceConstraints_MD_SecurityConstraints_handlingDescription;
                }
            }

            #endregion

            //Section 16.12 resourceConstraints Section from SkippedDoc.  0..*            
            XmlNodeList resConstraints = inboundMetadataRecordSkippedElements.DocumentElement.SelectNodes(MD_dataInfoNodeXpath + "/*[local-name()='resourceConstraints']");
            foreach (XmlNode skippedNode in resConstraints)
            {
                constructChildNodeUnderParent(outbound_md_DataIdSection, skippedNode, true);
                skippedNode.RemoveAll();
                removeEmptyParentNodes(skippedNode);
            }

            //Section 16.13 aggregationInfo Section from SkippedDoc.  0..*            
            XmlNodeList agInfo = inboundMetadataRecordSkippedElements.DocumentElement.SelectNodes(MD_dataInfoNodeXpath + "/*[local-name()='aggregationInfo']");
            foreach (XmlNode skippedNode in agInfo)
            {
                constructChildNodeUnderParent(outbound_md_DataIdSection, skippedNode, true);
                skippedNode.RemoveAll();
                removeEmptyParentNodes(skippedNode);
            }

            //Section 16.14 spatialRepresentationType Section from SkippedDoc.  0..*            
            XmlNodeList spatialRep = inboundMetadataRecordSkippedElements.DocumentElement.SelectNodes(
                MD_dataInfoNodeXpath + "/*[local-name()='spatialRepresentationType']");
            foreach (XmlNode skippedNode in spatialRep)
            {
                constructChildNodeUnderParent(outbound_md_DataIdSection, skippedNode, true);
                skippedNode.RemoveAll();
                removeEmptyParentNodes(skippedNode);
            }

            //Section 16.15 spatialResolution Section from SkippedDoc.  0..*            
            XmlNodeList spatialRes = inboundMetadataRecordSkippedElements.DocumentElement.SelectNodes(MD_dataInfoNodeXpath + "/*[local-name()='spatialResolution']");
            foreach (XmlNode skippedNode in spatialRes)
            {
                constructChildNodeUnderParent(outbound_md_DataIdSection, skippedNode, true);
                skippedNode.RemoveAll();
                removeEmptyParentNodes(skippedNode);
            }

            //Section 16.16 Language (required) Copy from main language section under root
            //Cannot see a use case for multiple occurances
            constructChildNodeUnderParent(
                outbound_md_DataIdSection,
                "./*[local-name()='identificationInfo']/*[local-name()='MD_DataIdentification']/*[local-name()='language']",
                _language, false, true, false);

            //Section 16.18 IsoTopicCat  (Req'd for EPA)

            if (kwIsoTopicCatList != null)
            {
                if (kwIsoTopicCatList.Count > 0)
                {
                    foreach (string tc in kwIsoTopicCatList)
                    {
                        //XmlNode isoTopicTemplateSection = constructIsoTopicCategorySection();
                        //constructChildNodeUnderParent(outbound_md_DataIdSection, isoTopicTemplateSection, true);
                        constructChildNodeUnderParent(outbound_md_DataIdSection, IsoNodeXpaths.idInfo_keywordsIsoTopicCategoryXpath,
                            tc, false, true,false);
                    }
                }
            }

            //Section 16.19 environmentalDescription Section from SkippedDoc.  0..1            
            XmlNode enviroDes = inboundMetadataRecordSkippedElements.DocumentElement.SelectSingleNode(MD_dataInfoNodeXpath + "/*[local-name()='environmentDescription']");
            if (enviroDes !=null)
            {
                constructChildNodeUnderParent(outbound_md_DataIdSection, enviroDes, true);
                enviroDes.RemoveAll();
                removeEmptyParentNodes(enviroDes);
            }

            //Sections 16.20 Extent, spatial and temporal

            #region  Section for spatial and temporal code
            //Handle null values. EPA makes this required          
            //Deep Clone the entire section.  Unused sections are removed later on.
            //ToDo:  refactor! but works for now.
            XmlNode extentNodeFromTemplate = templateMetadataRecord.DocumentElement.SelectSingleNode(
                "./*[local-name()='identificationInfo']/*[local-name()='MD_DataIdentification']/*[local-name()='extent']");//*[local-name()='EX_Extent']");
            XmlNode extentNodeOut = outbound_md_DataIdSection;//.SelectSingleNode("./*[local-name()='extent']");
            constructChildNodeUnderParent(extentNodeOut, extentNodeFromTemplate, true); //extent            
            //constructChildNodeUnderParent(extentNodeOut.LastChild, extentNodeFromTemplate.FirstChild, false); //EX_Extent
            //constructChildNodeUnderParent(extentNodeOut.LastChild.FirstChild, extentNodeFromTemplate.FirstChild.ChildNodes[0], true); //description
            //constructChildNodeUnderParent(extentNodeOut.LastChild.FirstChild, extentNodeFromTemplate.FirstChild.ChildNodes[1], true); //geographicElement

            if (!string.IsNullOrEmpty(_idInfo_extent_description))
            {                
                outboundMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.idInfo_extent_descriptionXpath).FirstChild.InnerText =
                    _idInfo_extent_description;
            }
            if (_idInfo_extent_geographicBoundingBox_eastLongDD == 0.0 
                | _idInfo_extent_geographicBoundingBox_westLongDD == 0.0
                |_idInfo_extent_geographicBoundingBox_northLatDD == 0.0
                |_idInfo_extent_geographicBoundingBox_southLatDD == 0.0
                )
            {
                //if any one of them are not completed, do not populate any of the remaining section.
            }
            else
            {
                outboundMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.idInfo_extent_geographicBoundingBox_eastLongDDXpath).FirstChild.InnerText =
                    _idInfo_extent_geographicBoundingBox_eastLongDD.ToString();
                outboundMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.idInfo_extent_geographicBoundingBox_westLongDDXpath).FirstChild.InnerText =
                    _idInfo_extent_geographicBoundingBox_westLongDD.ToString();
                outboundMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.idInfo_extent_geographicBoundingBox_northLatDDXpath).FirstChild.InnerText =
                    _idInfo_extent_geographicBoundingBox_northLatDD.ToString();
                outboundMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.idInfo_extent_geographicBoundingBox_southLatDDXpath).FirstChild.InnerText =
                    _idInfo_extent_geographicBoundingBox_southLatDD.ToString();
            }
            
            //TemporalExtent (this sections was part of the deep clone from above)
            //First Check to see which type we have, if any and only implement one of them
            //If both are null then don't do anything since anything with *template* will be removed later on
            //Only one of the conditions will be implemented even there are both types.
            if (_idInfo_extent_temporalExtent.TimeInstant != null)
            {
                XmlNode tiNode = outboundMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.idInfo_extent_temporalExtentXpath + "/*[local-name()='TimeInstant']");

                if (!string.IsNullOrEmpty(_idInfo_extent_temporalExtent.TimeInstant.extent__TimeInstant__description))
                { tiNode.SelectSingleNode("./*[local-name()='description']").InnerText = _idInfo_extent_temporalExtent.TimeInstant.extent__TimeInstant__description; }


                if (!string.IsNullOrEmpty(_idInfo_extent_temporalExtent.TimeInstant.extent__TimeInstant__timePosition))
                { }
                
                DateTime dt;
                bool isValueDate = DateTime.TryParse(_idInfo_extent_temporalExtent.TimeInstant.extent__TimeInstant__timePosition, out dt);
                if (isValueDate)
                {
                    tiNode.SelectSingleNode("./*[local-name()='timePosition']").InnerText = _idInfo_extent_temporalExtent.TimeInstant.extent__TimeInstant__timePosition; 
                }
                else
                {
                    //Create the attribute
                    XmlAttribute indTimeAtt = outboundMetadataRecord.CreateAttribute("indeterminatePosition");
                    indTimeAtt.Value = (!string.IsNullOrEmpty(_idInfo_extent_temporalExtent.TimeInstant.extent__TimeInstant__timePosition)) ?
                        _idInfo_extent_temporalExtent.TimeInstant.extent__TimeInstant__timePosition : "unknown";
                    
                    //Remove the *template* innerText and append the attribute
                    tiNode.SelectSingleNode("./*[local-name()='timePosition']").InnerText = "";
                    XmlAttributeCollection ac = tiNode.SelectSingleNode("./*[local-name()='timePosition']").Attributes;
                    ac.Append(indTimeAtt);               
                }
            }
            else if (_idInfo_extent_temporalExtent.TimePeriod != null)//This section will be skipped if TimeInstant is not null
            {
                XmlNode tpNode = outboundMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.idInfo_extent_temporalExtentXpath + "/*[local-name()='TimePeriod']");

                if (!string.IsNullOrEmpty(_idInfo_extent_temporalExtent.TimePeriod.extent__TimePeriod__description))
                { tpNode.SelectSingleNode("./*[local-name()='description']").InnerText = _idInfo_extent_temporalExtent.TimePeriod.extent__TimePeriod__description; }
                
                //ToDo: Refactor later!
                DateTime dt;
                bool isValueDate = DateTime.TryParse(_idInfo_extent_temporalExtent.TimePeriod.extent__TimePeriod__beginPosition, out dt);
                if (isValueDate)
                {
                    tpNode.SelectSingleNode("./*[local-name()='beginPosition']").InnerText = idInfo_extent_temporalExtent.TimePeriod.extent__TimePeriod__beginPosition;
                }
                else
                {
                    
                    XmlAttribute beginInde = outboundMetadataRecord.CreateAttribute("indeterminatePosition");
                    beginInde.Value = (!string.IsNullOrEmpty(_idInfo_extent_temporalExtent.TimePeriod.extent__TimePeriod__beginPosition)) ?
                        _idInfo_extent_temporalExtent.TimePeriod.extent__TimePeriod__beginPosition : "unknown";
                    
                    tpNode.SelectSingleNode("./*[local-name()='beginPosition']").InnerText = "";  //removes the *template* text
                    XmlAttributeCollection ac = tpNode.SelectSingleNode("./*[local-name()='beginPosition']").Attributes;
                    ac.Append(beginInde);
                                        
                }

                isValueDate = DateTime.TryParse(_idInfo_extent_temporalExtent.TimePeriod.extent__TimePeriod__endPosition, out dt);
                if (isValueDate)
                {                    
                    tpNode.SelectSingleNode("./*[local-name()='endPosition']").InnerText = idInfo_extent_temporalExtent.TimePeriod.extent__TimePeriod__endPosition;
                }
                else
                {
                    XmlAttribute endInde = outboundMetadataRecord.CreateAttribute("indeterminatePosition");
                    endInde.Value = (!string.IsNullOrEmpty(_idInfo_extent_temporalExtent.TimePeriod.extent__TimePeriod__endPosition)) ?
                        _idInfo_extent_temporalExtent.TimePeriod.extent__TimePeriod__endPosition : "unknown";
                    
                    tpNode.SelectSingleNode("./*[local-name()='endPosition']").InnerText = "";  //removes the *template* text
                    XmlAttributeCollection ac = tpNode.SelectSingleNode("./*[local-name()='endPosition']").Attributes;
                    ac.Append(endInde);
                }

                if (!string.IsNullOrEmpty(_idInfo_extent_temporalExtent.TimePeriod.extent__TimePeriod__timeInterval))
                {
                    tpNode.SelectSingleNode("./*[local-name()='timeInterval']").InnerText = _idInfo_extent_temporalExtent.TimePeriod.extent__TimePeriod__timeInterval;
                    tpNode.SelectSingleNode("./*[local-name()='timeInterval']").Attributes["unit"].Value =
                    _idInfo_extent_temporalExtent.TimePeriod.extent__TimePeriod__timeIntervalUnit;
                }
            }
            #endregion

            //Section 16.20 Extent Section from SkippedDoc.  0..*            
            XmlNodeList otherExtent = inboundMetadataRecordSkippedElements.DocumentElement.SelectNodes(MD_dataInfoNodeXpath + "/*[local-name()='extent']");
            foreach (XmlNode skippedNode in otherExtent)
            {
                constructChildNodeUnderParent(outbound_md_DataIdSection, skippedNode, true);
                skippedNode.RemoveAll();
                removeEmptyParentNodes(skippedNode);
            }

            //Section 16.21 environmentalDescription Section from SkippedDoc.  0..1            
            XmlNode supInfo = inboundMetadataRecordSkippedElements.DocumentElement.SelectSingleNode(MD_dataInfoNodeXpath + "/*[local-name()='supplementalInformation']");
            if (supInfo != null)
            {
                constructChildNodeUnderParent(outbound_md_DataIdSection, supInfo, true);
                supInfo.RemoveAll();
                removeEmptyParentNodes(supInfo);
            }
                       
            //Section 16  0..*  Add Any additional repeating MD or SV sections from the skipped document.            
            //XmlNodeList otherMDandSvInfo = inboundMetadataRecordSkippedElements.DocumentElement.SelectNodes("./*[local-name()='identificationInfo'");
            //foreach (XmlNode skippedNode in otherExtent)
            //{
            //    constructChildNodeUnderParent(outbound_md_DataIdSection, skippedNode, true);
            //    skippedNode.RemoveAll();
            //    removeEmptyParentNodes(skippedNode);
            //}

            //Clean up and remove citation section if there are not values that get inserted.
            if (!citationCiSectionNode.HasChildNodes) { removeEmptyParentNodes(citationCiSectionNode); }

            #region test area for checking for missing parent nodes and inserting the missing nodes

            //List<XmlNode> importNodeList = new List<XmlNode>();
            ////XPathNavigator xpNav = templateMetadataRecord.DocumentElement.SelectSingleNode("./*[local-name()='identificationInfo']").CreateNavigator();
            
            ////create a shallow clone of each node up to the first matching node
            //XmlNode n = templateMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.IdInfo_citation_TitleXpath);
            //    //"./*[local-name()='identificationInfo']/*[local-name()='MD_DataIdentification']/*[local-name()='citation']");
            ////XmlNode outboundNodeTest = outboundMetadataRecord.DocumentElement.SelectSingleNode("./*[local-name()='identificationInfo']");
            ////importNodeList.Add(templateMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.IdInfo_citation_TitleXpath).CloneNode(true));
            //int i = 0;
            //while (outbound_md_DataIdSection.Name != n.Name)
            //{
            //    if (i == 0) { importNodeList.Add(n.CloneNode(true)); }//Deep clone
            //    else { importNodeList.Add(n.CloneNode(false)); }
            //    n = n.ParentNode;
            //    i++;
            //}
            //importNodeList.Reverse();            
            //foreach (XmlNode clonedNode in importNodeList)
            //{
            //    //Check if the node exists before inserting??? outboundMetadataRecord.ex
            //    XmlNodeList outNS = outbound_md_DataIdSection.ChildNodes;
                
            //    XmlNode importer = outboundMetadataRecord.ImportNode(clonedNode, true);
            //    outbound_md_DataIdSection.AppendChild(importer);
            //    outbound_md_DataIdSection = outbound_md_DataIdSection.FirstChild;
            //}
            
                                                
            
            
                       
            #endregion
            
        }


        private void construct_CI_DateSection(XmlNode outboundParentNode, string dateValue, string dateTypeCodeListValue, string XpathToTemplateCI_DateSection)
        {
            XmlNode nodeFromTemplateRecord = templateMetadataRecord.DocumentElement.SelectSingleNode(XpathToTemplateCI_DateSection).CloneNode(true);

            nodeFromTemplateRecord.FirstChild.SelectSingleNode("./*[local-name()='date']").FirstChild.InnerText = dateValue;
            nodeFromTemplateRecord.FirstChild.SelectSingleNode("./*[local-name()='dateType']").FirstChild.InnerText = dateTypeCodeListValue;
            nodeFromTemplateRecord.FirstChild.SelectSingleNode("./*[local-name()='dateType']").FirstChild.Attributes["codeListValue"].Value = dateTypeCodeListValue;

            XmlNode nodeImporter = outboundMetadataRecord.ImportNode(nodeFromTemplateRecord, true);
            outboundParentNode.AppendChild(nodeImporter);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CI_ResponsiblePartyList"></param>
        /// <param name="xpathToCI_ResponsiblePartySection">The Complete Xpath Expression from Root to the Parent section containing the CI_ResponsibleParty object</param>
        private void constructCI_ResponsiblePartyMarkUp(List<CI_ResponsibleParty> CI_ResponsiblePartyList, string xpathToCI_ResponsiblePartySection)
        {
            //*This is a repeating section.  Grab one from the template and then repeat for each object in the list
            //1. Grab the correct CI_RP section from the template metadata record
            //2. Loop thru each sub-element and add the values.  Handle Codelist values
            //3. Remove any un-populated elements (remove *template*)
            //4. Append into the outgoing record.  **This assumes there are not nodes after this section.
            //XmlNodeList nodeListforCI_RpSection; // = templateMetadataRecord.SelectSingleNode            
            int i = 0;//use as insertion index for repeated sections.
            foreach (CI_ResponsibleParty rpObject in CI_ResponsiblePartyList)
            {
                XmlNode responsiblePartySectionTemplate = templateMetadataRecord.DocumentElement.SelectSingleNode(xpathToCI_ResponsiblePartySection).CloneNode(true);
                //XmlNodeList nodeListforCI_RpSection = responsiblePartySectionTemplate.                
                //CI_ResponsibleParty rp = new CI_ResponsibleParty();
                object rpobj = rpObject;
                PropertyInfo[] propInfo2 = rpobj.GetType().GetProperties();
                //ToDo:  Not sure if we need an Xpath expression List, but if so, we can do that here
                //responsiblePartySubSectionXpath = new List<string>();
                foreach (PropertyInfo p in propInfo2)
                {
                    if (p.Name == "dcatProgramCode")
                    {
                        ////Create the attribute
                        string pCode = (p.GetValue(rpObject, null) != null) ? p.GetValue(rpObject, null).ToString() : "";
                        if (pCode != "")
                        {
                            XmlAttribute pcodeAttribut = responsiblePartySectionTemplate.OwnerDocument.CreateAttribute("xlink", "title", "http://www.w3.org/1999/xlink");
                            pcodeAttribut.Value = pCode;
                            XmlAttributeCollection ac = responsiblePartySectionTemplate.Attributes;
                            ac.Append(pcodeAttribut);

                            //XmlAttribute indTimeAtt = outboundMetadataRecord.CreateAttribute("indeterminatePosition");
                            //indTimeAtt.Value = (!string.IsNullOrEmpty(_idInfo_extent_temporalExtent.TimeInstant.extent__TimeInstant__timePosition)) ?
                            //    _idInfo_extent_temporalExtent.TimeInstant.extent__TimeInstant__timePosition : "unknown";

                            ////Remove the *template* innerText and append the attribute
                            //tiNode.SelectSingleNode("./*[local-name()='timePosition']").InnerText = "";
                            //XmlAttributeCollection ac = tiNode.SelectSingleNode("./*[local-name()='timePosition']").Attributes;
                            //ac.Append(indTimeAtt);
                        }
                    }
                    else
                    {
                        string childNodeXpath = ".";
                        string[] splitby = new string[] { "__" };
                        string[] nameParts = p.Name.Split(splitby, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string entry in nameParts)
                        {
                            childNodeXpath += "/*[local-name()='" + entry + "']";
                        }
                        string nodeValue = (p.GetValue(rpObject, null) != null) ? p.GetValue(rpObject, null).ToString() : "";
                        XmlNode targetNode = responsiblePartySectionTemplate.FirstChild.SelectSingleNode(childNodeXpath);
                        if (targetNode != null)
                        {
                            //If the value is null or empty from the class then remove it except for rolecode
                            if (nodeValue == "" && p.Name != "role")
                            {
                                //Delete the node
                                //targetNode.ParentNode.RemoveChild(targetNode);
                                targetNode.RemoveAll();
                                removeEmptyParentNodes(targetNode);
                            }
                            else
                            {
                                if (targetNode.HasChildNodes == true) { targetNode.FirstChild.InnerText = nodeValue; }
                                else { targetNode.InnerText = nodeValue; }
                                if (p.Name == "role") { targetNode.FirstChild.Attributes["codeListValue"].Value = nodeValue; }
                                if (p.Name == "contactInfo__CI_Contact__onlineResource__CI_OnlineResource__function")
                                { targetNode.FirstChild.Attributes["codeListValue"].Value = nodeValue; }

                            }
                        }
                    }

                }
                //All values Set.  Now insert into the outgoing document
                //Based on the template record, there should be at least 1 occurance of a contact node.  The first CI_RP list item
                //will replace the contents of that node.  Additional list items will be inserted after the last inserted item.  THis 
                //is tracked by incrementing the int i variable

                XmlNode firstCiRpSection = outboundMetadataRecord.DocumentElement.SelectSingleNode(xpathToCI_ResponsiblePartySection);
                XmlNode ci_rpSectionImporter = outboundMetadataRecord.ImportNode(responsiblePartySectionTemplate, true);
                if (i == 0)
                {
                    firstCiRpSection.ParentNode.ReplaceChild(ci_rpSectionImporter, firstCiRpSection);
                }
                else
                {
                    //Append additional occurances after the last inserted
                    XmlNode lastInsertedNodeRef = outboundMetadataRecord.DocumentElement.SelectNodes(xpathToCI_ResponsiblePartySection)[i - 1];
                    firstCiRpSection.ParentNode.InsertAfter(ci_rpSectionImporter, lastInsertedNodeRef);

                }
                XmlNode ciSection = outboundMetadataRecord.DocumentElement.SelectNodes(xpathToCI_ResponsiblePartySection)[i];
                
                i++;
            }

        }
        /// <summary>
        /// Pass in a deep clone of the template node and the class containing values.  The class will be used to create the
        /// Xpath and populate each corresponding Element.  Unpopulated elements will be removed.  The returned XmlNode
        /// will need be handled.
        /// </summary>
        /// <param name="objectContainingValues"></param>
        /// <param name="templateNodeClone"></param>
        /// <returns></returns>
        private XmlNode constructNodeFragment(object objectContainingValues, XmlNode templateNodeClone)
        {
            //XmlNode nodeFragment = templateNodeFromMetadataRecord;

            object rpobj = objectContainingValues;
            PropertyInfo[] propInfo2 = rpobj.GetType().GetProperties();
            //ToDo:  Not sure if we need an Xpath expression List, but if so, we can do that here
            //responsiblePartySubSectionXpath = new List<string>();
            foreach (PropertyInfo p in propInfo2)
            {
                string childNodeXpath = ".";
                string[] splitby = new string[] { "__" };
                string[] nameParts = p.Name.Split(splitby, StringSplitOptions.RemoveEmptyEntries);
                foreach (string entry in nameParts)
                {
                    childNodeXpath += "/*[local-name()='" + entry + "']";
                }
                string nodeValue = (p.GetValue(objectContainingValues, null) != null) ? p.GetValue(objectContainingValues, null).ToString() : "";
                XmlNode targetNode = templateNodeClone.SelectSingleNode(childNodeXpath);
                if (targetNode != null)
                {
                    //If the value is null or empty from the class then remove it except for rolecode
                    if (nodeValue == "")
                    {
                        //Delete the node
                        //targetNode.ParentNode.RemoveChild(targetNode);
                        targetNode.RemoveAll();
                        removeEmptyParentNodes(targetNode);
                    }
                    else
                    {
                        if (targetNode.HasChildNodes == true)
                        {
                            targetNode.FirstChild.InnerText = nodeValue;
                            if (targetNode.FirstChild.NodeType != XmlNodeType.Text)
                            {
                                //Console.WriteLine("Parent NodeType: " + targetNode.NodeType.ToString() + " ChildNode Type: " + targetNode.FirstChild.NodeType.ToString());
                                //XmlNode firstCNode = targetNode.FirstChild;
                                XmlNode attributeNode = targetNode.FirstChild.Attributes["codeListValue"];
                                if (attributeNode != null) { targetNode.FirstChild.Attributes["codeListValue"].Value = nodeValue; }
                            }
                        }
                        else { targetNode.InnerText = nodeValue; }                        
                    }
                }

            }            
            return templateNodeClone;
        }

        /// <summary>
        /// Overloaded Method to Replace an Existing CI_ResponsibleParty at the specified node
        /// </summary>
        /// <param name="CI_ResponsiblePartyItem"></param>
        /// <param name="outboundResponsiblePartySection">Existing Node Refernce To be replaced</param>
        /// <param name="xpathToCI_ResponsiblePartySection">Xpath to a template CI_Responsible Party Section</param>
        private void constructCI_ResponsiblePartyMarkUp(CI_ResponsibleParty CI_ResponsiblePartyItem, XmlNode outboundResponsiblePartySection,
            string xpathToCI_ResponsiblePartySection)
        {
            //*This is a repeating section.  Grab one from the template and then repeat for each object in the list
            //1. Grab the correct CI_RP section from the template metadata record
            //2. Loop thru each sub-element and add the values.  Handle Codelist values
            //3. Remove any un-populated elements (remove *template*)
            //4. Append into the outgoing record.  **This assumes there are not nodes after this section.
            //XmlNodeList nodeListforCI_RpSection; // = templateMetadataRecord.SelectSingleNode            
            
            //int i = 0;//use as insertion index for repeated sections.
            CI_ResponsibleParty rpObject = CI_ResponsiblePartyItem;
            //foreach (CI_ResponsibleParty rpObject in CI_ResponsiblePartyList)
            //{
                XmlNode responsiblePartySectionTemplate = templateMetadataRecord.DocumentElement.SelectSingleNode(xpathToCI_ResponsiblePartySection).CloneNode(true);
                //XmlNodeList nodeListforCI_RpSection = responsiblePartySectionTemplate.                
                //CI_ResponsibleParty rp = new CI_ResponsibleParty();
                object rpobj = rpObject;
                PropertyInfo[] propInfo2 = rpobj.GetType().GetProperties();
                //ToDo:  Not sure if we need an Xpath expression List, but if so, we can do that here
                //responsiblePartySubSectionXpath = new List<string>();
                foreach (PropertyInfo p in propInfo2)
                {
                    if (p.Name == "dcatProgramCode")
                    {
                        ////Create the attribute
                        string pCode = (p.GetValue(rpObject, null) != null) ? p.GetValue(rpObject, null).ToString() : "";
                        if (pCode != "")
                        {
                            XmlAttribute pcodeAttribut = responsiblePartySectionTemplate.OwnerDocument.CreateAttribute("xlink", "title", "http://www.w3.org/1999/xlink");
                            pcodeAttribut.Value = pCode;
                            XmlAttributeCollection ac = responsiblePartySectionTemplate.Attributes;
                            ac.Append(pcodeAttribut);

                            //XmlAttribute indTimeAtt = outboundMetadataRecord.CreateAttribute("indeterminatePosition");
                            //indTimeAtt.Value = (!string.IsNullOrEmpty(_idInfo_extent_temporalExtent.TimeInstant.extent__TimeInstant__timePosition)) ?
                            //    _idInfo_extent_temporalExtent.TimeInstant.extent__TimeInstant__timePosition : "unknown";

                            ////Remove the *template* innerText and append the attribute
                            //tiNode.SelectSingleNode("./*[local-name()='timePosition']").InnerText = "";
                            //XmlAttributeCollection ac = tiNode.SelectSingleNode("./*[local-name()='timePosition']").Attributes;
                            //ac.Append(indTimeAtt);
                        }
                    }
                    else
                    {
                        string childNodeXpath = ".";
                        string[] splitby = new string[] { "__" };
                        string[] nameParts = p.Name.Split(splitby, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string entry in nameParts)
                        {
                            childNodeXpath += "/*[local-name()='" + entry + "']";
                        }
                        string nodeValue = (p.GetValue(rpObject, null) != null) ? p.GetValue(rpObject, null).ToString() : "";
                        XmlNode targetNode = responsiblePartySectionTemplate.FirstChild.SelectSingleNode(childNodeXpath);
                        if (targetNode != null)
                        {
                            //If the value is null or empty from the class then remove it except for rolecode
                            if (nodeValue == "" && p.Name != "role")
                            {
                                //Delete the node
                                //targetNode.ParentNode.RemoveChild(targetNode);
                                targetNode.RemoveAll();
                                removeEmptyParentNodes(targetNode);
                            }
                            else
                            {
                                if (targetNode.HasChildNodes == true) { targetNode.FirstChild.InnerText = nodeValue; }
                                else { targetNode.InnerText = nodeValue; }
                                if (p.Name == "role") { targetNode.FirstChild.Attributes["codeListValue"].Value = nodeValue; }
                                if (p.Name == "contactInfo__CI_Contact__onlineResource__CI_OnlineResource__function")
                                { targetNode.FirstChild.Attributes["codeListValue"].Value = nodeValue; }

                            }
                        }
                    }

                }
                //All values Set.  Now insert into the outgoing document
                //Based on the template record, there should be at least 1 occurance of a contact node.  The first CI_RP list item
                //will replace the contents of that node.  Additional list items will be inserted after the last inserted item.  THis 
                //is tracked by incrementing the int i variable

                XmlNode firstCiRpSection = outboundResponsiblePartySection;
                    //outboundMetadataRecord.DocumentElement.SelectSingleNode(xpathToCI_ResponsiblePartySection);
                XmlNode ci_rpSectionImporter = outboundMetadataRecord.ImportNode(responsiblePartySectionTemplate, true);
                //if (i == 0)
                //{
                    firstCiRpSection.ParentNode.ReplaceChild(ci_rpSectionImporter, firstCiRpSection);
                //}
                //else
                //{
                //    //Append additional occurances after the last inserted
                //    XmlNode lastInsertedNodeRef = outboundMetadataRecord.DocumentElement.SelectNodes(xpathToCI_ResponsiblePartySection)[i - 1];
                //    firstCiRpSection.ParentNode.InsertAfter(ci_rpSectionImporter, lastInsertedNodeRef);

                //}
                //XmlNode ciSection = outboundMetadataRecord.DocumentElement.SelectNodes(xpathToCI_ResponsiblePartySection)[i];
                //i++;
            //}

        }                  
        /// <summary>
        /// DO not use this... it does not nest topic keywords correctly.
        /// </summary>
        /// <returns></returns>
        private XmlNode constructIsoTopicCategorySection()
        {                        
            XmlNode keywordsTemplateSection = 
                templateMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.idInfo_keywordsIsoTopicCategoryXpath).CloneNode(true);
            XmlDocumentFragment keywordListFrag = templateMetadataRecord.CreateDocumentFragment();

            foreach (string s in kwIsoTopicCatList) //kwEpaList)
            {
                //THis will insert all the keywords at the top of the keywords section
                XmlNode keywordItem = keywordsTemplateSection.CloneNode(true);                
                keywordItem.FirstChild.InnerText = s;                
                keywordListFrag.AppendChild(keywordItem);
            }

            //Remove the *template* nodes
            XmlNode templateNode = keywordsTemplateSection.SelectSingleNode("./*['*template*']");
            keywordsTemplateSection.ReplaceChild(keywordListFrag, templateNode);            
            
            return keywordsTemplateSection;
        }
        
        private XmlNode constructKeywordSection(List<string> KeywordList, string xpathToKeywordSection)
        {
            //This assumes there is a template section in a specific order.
            //The template should contain one keyword element populated with *template*.  This will be removed later on
            XmlNode keywordsTemplateSection = templateMetadataRecord.DocumentElement.SelectSingleNode(xpathToKeywordSection).CloneNode(true);
            XmlDocumentFragment keywordListFrag = templateMetadataRecord.CreateDocumentFragment();
            
            foreach (string s in KeywordList) //kwEpaList)
            {
                //THis will insert all the keywords at the top of the keywords section
                //Copies the first keyword element
                XmlNode keywordItem = keywordsTemplateSection.FirstChild.FirstChild.CloneNode(true);                   
                keywordItem.FirstChild.InnerText = s;
                
                //XmlDocumentFragment keywordFrag = templateMetadataRecord.CreateDocumentFragment();                             
                //XmlNode keyw = templateMetadataRecord.CreateElement("gmd:keyword");
                //keywordFrag.AppendChild(keyw);
                //XmlNode cs = templateMetadataRecord.CreateElement("gco:CharacterString");
                //cs.InnerText = s;
                //keywordFrag.FirstChild.AppendChild(cs);
                //keywordListFrag.AppendChild(keywordFrag);
                keywordListFrag.AppendChild(keywordItem);

                //Cannot insert InnerXML if there are namespaces.  The following won't work:
                //keywordListFrag.InnerXml = "<gmd:keyword><gco:CharacterString>Agriculture</gco:CharacterString></gmd:keyword>"+
                //    "<gmd:keyword><gco:CharacterString>Cows</gco:CharacterString></gmd:keyword>";

            }

            //XmlNodeList templateNodes = keywordsTemplateSection.SelectNodes("./*['*template*']");

            //Remove the *template* node
            keywordsTemplateSection.FirstChild.ReplaceChild(
                keywordListFrag,
                keywordsTemplateSection.FirstChild.SelectSingleNode("./*['*template*']"));
            
            //keywordsTemplateSection.FirstChild.PrependChild(keywordListFrag);
            return keywordsTemplateSection;

        }

        private void construct_distributionInfoSection()
        {
            //The root section should already exist.  Start inserting each subsection as needed

            //All child elements will be nested below the distributor parent element
            //A document could have multiple distributor elements
            //Will need to keep track the order in which they get inserted. 1 gmd:distributor for each CI_RP
            ////<gmd:distributionInfo>
            //      //<gmd:MD_Distribution>
            //           //<gmd:distributor> [1-N]
            //                //MD_Distributor [1-1]  Set of information per distributorContact
            //                   //<gmd:distributorContact> 1-1!!
            //                         //CiRP...
            //                   //remaining sub elements per distributorContact
            if (_distributionInfo__MD_Distribution != null)
            {
                if (_distributionInfo__MD_Distribution.Count > 0)
                {
                    //MD_Distribution
                    string distInfoChildNodeXpath = "./*[local-name()='distributionInfo']/*[local-name()='MD_Distribution']";
                    constructChildNodeUnderParent(
                        outboundMetadataRecord.DocumentElement.SelectSingleNode("./*[local-name()='distributionInfo']"),
                        distInfoChildNodeXpath,
                        null, false, false, false);

                    int distributorIndex = 0;
                    foreach (MD_Distributor distributorItem in _distributionInfo__MD_Distribution)
                    {
                        //distributor;  Repeating.  Need to track the index of this element for all child elements for Xpath Expressions
                        //              Each distributor will element will be appended after the last distributor section.
                        constructChildNodeUnderParent(
                            outboundMetadataRecord.DocumentElement.SelectSingleNode(distInfoChildNodeXpath),
                            IsoNodeXpaths.distributionInfo__MD_DistributionXpath,
                            null, false, false, false);

                        //MD_Distributor; Occurs once under the parent distributor.  Insert into corresponding distributor parent using distributorIndex
                        constructChildNodeUnderParent(
                          outboundMetadataRecord.DocumentElement.SelectNodes(IsoNodeXpaths.distributionInfo__MD_DistributionXpath)[distributorIndex],
                          IsoNodeXpaths.distributionInfo__MD_DistributionXpath + "/*[local-name()='MD_Distributor']",
                          null, false, false, false);


                        //Create a key,value pair of element name and xpath to get to each child node
                        MD_Distributor mdDistributor = new MD_Distributor();
                        object distRP = mdDistributor;

                        List<KeyValuePair<string, string>> kvList = extractPartentXmlElementNameFromClass(distRP);
                        //for (int i = 0; i < kvList.Count; i++)
                        //{
                        //    Console.WriteLine("Key " + kvList[i].Key.ToString()
                        //        + "  Value: " + kvList[i].Value.ToString());
                        //}

                        //Dan Was Here

                        //Under this node include only one CI_Responsible Party Package
                        //string pname = "distributorContact__CI_ResponsibleParty";
                        string pname = "distributorContact";
                        KeyValuePair<string, string> kv = kvList.Find(delegate(KeyValuePair<string, string> kv1) { return kv1.Key == pname; });

                        XmlNode distributorContactAtIndex = outboundMetadataRecord.DocumentElement.SelectNodes(
                            IsoNodeXpaths.distributionInfo__MD_DistributionXpath)[distributorIndex].SelectSingleNode("./*[local-name()='MD_Distributor']");

                        constructChildNodeUnderParent(
                            distributorContactAtIndex,
                            IsoNodeXpaths.distributionInfo__MD_DistributionXpath + "/*[local-name()='MD_Distributor']/*[local-name()='distributorContact']",
                            null, false, false, false);

                        constructCI_ResponsiblePartyMarkUp(distributorItem.distributorContact,
                            distributorContactAtIndex.FirstChild, IsoNodeXpaths.distributionInfo__MD_DistributionXpath + kv.Value);


                        if (distributorItem.distributionOrderProcess__MD_StandardOrderProcess.Count > 0)
                        {
                            //Key distributionOrderProcess__MD_StandardOrderProcess  
                            //Value: ./*[local-name()='MD_Distributor']/*[local-name()='distributionOrderProcess']/*[local-name()='MD_StandardOrderProcess']
                            //Repeat the
                            int SOPindex = 0;
                            foreach (MD_StandardOrderProcess SOP in distributorItem.distributionOrderProcess__MD_StandardOrderProcess)
                            {
                                //For Each, clone, assign values, removed unused elements, then insert.
                                string SOPXpath =
                                    "./*[local-name()='distributionInfo']/*[local-name()='MD_Distribution']/*[local-name()='distributor']/*[local-name()='MD_Distributor']/*[local-name()='distributionOrderProcess']";

                                XmlNode templateSectionNodeClone = templateMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.distributionInfo__MD_DistributionXpath)
                                    .SelectSingleNode("./*[local-name()='MD_Distributor']/*[local-name()='distributionOrderProcess']/*[local-name()='MD_StandardOrderProcess']")
                                    .CloneNode(true);
                                XmlNode processedSOPSection = constructNodeFragment(SOP, templateSectionNodeClone);

                                constructChildNodeUnderParent(distributorContactAtIndex,
                                    SOPXpath,
                                    null, false, false, false);
                                XmlNode SOPElementAtIndex = distributorContactAtIndex.SelectNodes("./*[local-name()='distributionOrderProcess']")[SOPindex];

                                constructChildNodeUnderParent(SOPElementAtIndex, processedSOPSection, true);

                                SOPindex++;

                                //string s = SOP.fees + SOP.plannedAvailableDateTime + SOP.orderingInstructions + SOP.turnaround;
                            }

                        }
                        if (distributorItem.distributorFormat__MD_Format.Count > 0)
                        {
                            //Key distributorFormat__MD_Format  
                            //Value: ./*[local-name()='MD_Distributor']/*[local-name()='distributorFormat']/*[local-name()='MD_Format']
                            int MDFindex = 0;
                            foreach (MD_Format MDF in distributorItem.distributorFormat__MD_Format)
                            {
                                string MSFXpath =
                                    "./*[local-name()='distributionInfo']/*[local-name()='MD_Distribution']/*[local-name()='distributor']/*[local-name()='MD_Distributor']/*[local-name()='distributorFormat']";
                                XmlNode templateSectionNodeClone = templateMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.distributionInfo__MD_DistributionXpath)
                                    .SelectSingleNode("./*[local-name()='MD_Distributor']/*[local-name()='distributorFormat']/*[local-name()='MD_Format']")
                                    .CloneNode(true);
                                XmlNode processedSOPSection = constructNodeFragment(MDF, templateSectionNodeClone);

                                constructChildNodeUnderParent(distributorContactAtIndex,
                                    MSFXpath,
                                    null, false, false, false);
                                XmlNode SOPElementAtIndex = distributorContactAtIndex.SelectNodes("./*[local-name()='distributorFormat']")[MDFindex];

                                constructChildNodeUnderParent(SOPElementAtIndex, processedSOPSection, true);

                                MDFindex++;

                            }

                        }
                        if (distributorItem.distributorTransferOptions__MD_DigitalTransferOptions.Count > 0)
                        {
                            //Key distributorTransferOptions__MD_DigitalTransferOptions  
                            //Value: ./*[local-name()='MD_Distributor']/*[local-name()='distributorTransferOptions']/*[local-name()='MD_DigitalTransferOptions']
                            int DTOindex = 0;
                            foreach (MD_DigitalTransferOptions DTO in distributorItem.distributorTransferOptions__MD_DigitalTransferOptions)
                            {
                                string DTOXpath =
                                    "./*[local-name()='distributionInfo']/*[local-name()='MD_Distribution']/*[local-name()='distributor']/*[local-name()='MD_Distributor']/*[local-name()='distributorTransferOptions']";
                                XmlNode templateSectionNodeClone = templateMetadataRecord.DocumentElement.SelectSingleNode(IsoNodeXpaths.distributionInfo__MD_DistributionXpath)
                                    .SelectSingleNode("./*[local-name()='MD_Distributor']/*[local-name()='distributorTransferOptions']/*[local-name()='MD_DigitalTransferOptions']")
                                    .CloneNode(true);
                                XmlNode processedDTOSection = constructNodeFragment(DTO, templateSectionNodeClone);

                                constructChildNodeUnderParent(distributorContactAtIndex,
                                    DTOXpath,
                                    null, false, false, false);
                                XmlNode DTOElementAtIndex = distributorContactAtIndex.SelectNodes("./*[local-name()='distributorTransferOptions']")[DTOindex];

                                constructChildNodeUnderParent(DTOElementAtIndex, processedDTOSection, true);

                                DTOindex++;
                            }
                        }

                        distributorIndex++;
                    }
                }
            }

        }

        #region XML Utility Functions

        /// <summary>
        /// When deleting elements this recursively removes empty parent nodes including the node that is passed into this method.
        /// </summary>
        /// <param name="node"></param>
        private void removeEmptyParentNodes(XmlNode node)
        {
            if (node.NodeType == XmlNodeType.Document) { return; }
            else if (!node.HasChildNodes)
            {
                XmlNode pnode = node.ParentNode;
                node.ParentNode.RemoveChild(node);
                if (pnode.ParentNode != null)
                {
                    if (pnode.ParentNode.NodeType != XmlNodeType.Document)
                    {
                        removeEmptyParentNodes(pnode);
                    }
                }
            }
        }               

        /// <summary>
        /// Clone a node from template and insert an element value if present.  Pass in null to skip adding element value
        /// and just create a simple clone. And EmptyString value for elementValue will result in the methoded not running.
        /// </summary>
        /// <param name="outboundParentNode">A reference to the insertion point for the node (parent node)</param>
        /// <param name="xpathToElementToCopy"></param>
        /// <param name="elementValue">null value will skip adding the elment value. EmptyString value will skip entire method.  All other values will be added</param>
        /// <param name="populateCodeListValue">if true then value in elementValue will populate codelist</param>
        /// <param name="deepClone">true to copy all child nodes</param>
        /// <param name="replaceExistingNode">false will append to the end</param>
        private void constructChildNodeUnderParent(
            XmlNode outboundParentNode, string xpathToElementToCopy, string elementValue, bool populateCodeListValue, bool deepClone, bool replaceExistingNode)
        {
            if (elementValue != "")
            {
                XmlNode nodeFromTemplateRecord = templateMetadataRecord.DocumentElement.SelectSingleNode(xpathToElementToCopy).CloneNode(deepClone);
                if (elementValue != null) { nodeFromTemplateRecord.FirstChild.InnerText = elementValue; }
                if (populateCodeListValue == true) { nodeFromTemplateRecord.FirstChild.Attributes["codeListValue"].Value = elementValue; }

                XmlNode nodeImporter = outboundMetadataRecord.ImportNode(nodeFromTemplateRecord, true);
                if (replaceExistingNode == true)
                {
                    XmlNode nodeFromOutBoundDocToReplace = outboundMetadataRecord.DocumentElement.SelectSingleNode(xpathToElementToCopy);
                    nodeFromOutBoundDocToReplace.ParentNode.ReplaceChild(nodeImporter, nodeFromOutBoundDocToReplace);
                }
                else
                {
                    outboundParentNode.AppendChild(nodeImporter);
                }
            }
        }

        /// <summary>
        /// Clone a node by passing in references to the target parent node and template node
        /// The node will be appended to the end of the list of child nodes for the outboundParentNode
        /// </summary>
        /// <param name="outboundParentNode">reference to the target parent node</param>
        /// <param name="nodeFromTemplateToClone">child node to copy and append under parent</param>
        /// <param name="deepClone">true for a deep clone</param>
        private void constructChildNodeUnderParent(XmlNode outboundParentNode, XmlNode nodeFromTemplateToClone, bool deepClone)
        {
            XmlNode nodeFromTemplateRecord = nodeFromTemplateToClone.CloneNode(deepClone);
            XmlNode nodeImporter = outboundMetadataRecord.ImportNode(nodeFromTemplateRecord, true);

            outboundParentNode.AppendChild(nodeImporter);
        }

        #endregion


        static void ValidationCallback(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning)
                Console.Write("WARNING: ");
            else if (args.Severity == XmlSeverityType.Error)
                Console.Write("ERROR: ");

            Console.WriteLine(args.Message);
        }        
        
    }

    
    public class CI_Date
    {
        public DateTime Date { get; set; }
        public Enum dateType { get; set; }
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public class CI_ResponsibleParty
    {        
        public string individualName { get; set; }
        public string organisationName { get; set; }
        public string positionName { get; set; }
        public string contactInfo__CI_Contact__phone__CI_Telephone__voice { get; set; } //just one
        public string contactInfo__CI_Contact__phone__CI_Telephone__facsimile { get; set; }
        public string contactInfo__CI_Contact__address__CI_Address__deliveryPoint { get; set; }
        public string contactInfo__CI_Contact__address__CI_Address__city { get; set; }
        public string contactInfo__CI_Contact__address__CI_Address__administrativeArea { get; set; }
        public string contactInfo__CI_Contact__address__CI_Address__postalCode { get; set; }
        public string contactInfo__CI_Contact__address__CI_Address__country { get; set; }
        public string contactInfo__CI_Contact__address__CI_Address__electronicMailAddress { get; set; }
        public string contactInfo__CI_Contact__onlineResource__CI_OnlineResource__linkage { get; set; }//More properties under this.
        public string contactInfo__CI_Contact__onlineResource__CI_OnlineResource__function { get; set; } //link with CI_OnlineFunctionCode
        public string contactInfo__CI_Contact__hoursOfService { get; set; }
        public string contactInfo__CI_Contact__contactInstructions { get; set; }
        public string role { get; set; } //need to link with role-code values from codelist
        public string dcatProgramCode { get; set; }
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public class MD_Distributor
    {
        //Per distributor can have multiple distributionFormats and transfer options!
        public CI_ResponsibleParty distributorContact { get; set; }
        public List<MD_StandardOrderProcess> distributionOrderProcess__MD_StandardOrderProcess { get; set; }
        public List<MD_Format> distributorFormat__MD_Format { get; set; }        
        public List<MD_DigitalTransferOptions> distributorTransferOptions__MD_DigitalTransferOptions { get; set; }
        
        public MD_Distributor()
        {
            distributorContact = new CI_ResponsibleParty();
            distributionOrderProcess__MD_StandardOrderProcess = new List<MD_StandardOrderProcess>();
            distributorFormat__MD_Format = new List<MD_Format>();
            distributorTransferOptions__MD_DigitalTransferOptions = new List<MD_DigitalTransferOptions>();
        }
    }
    [StructLayout(LayoutKind.Sequential)]
    public class MD_Format
    {
        public string name { get; set; }
        public string version { get; set; }
        public string amendmentNumber { get; set; }
        public string specification { get; set; }
        public string fileDecompressionTechnique { get; set; }
    }
    //public class MD_Distributor
    //{
    //    public CI_ResponsibleParty distributorContact { get; set; }
    //    public List<MD_StandardOrderProcess> distributionOrderProcess { get; set; }
    //    //public MD_Format distributorFormat { get; set; } //Use if distributionFormatNot Provided
    //}
    [StructLayout(LayoutKind.Sequential)]
    public class MD_StandardOrderProcess
    {
        public string fees { get; set; }
        public string plannedAvailableDateTime { get; set; } //datetime
        public string orderingInstructions { get; set; }
        public string turnaround { get; set; }
    }
    [StructLayout(LayoutKind.Sequential)]
    public class MD_DigitalTransferOptions    
    {
        public string unitsOfDistribution { get; set; }
        public string transferSize { get; set; }
        public string onLine__CI_OnlineResource__linkage__URL { get; set; }
        public string onLine__CI_OnlineResource__protocol { get; set; }
        public string onLine__CI_OnlineResource__applicationProfile { get; set; }
        public string onLine__CI_OnlineResource__name { get; set; }
        public string onLine__CI_OnlineResource__description { get; set; }
        public string onLine__CI_OnlineResource__function { get; set; } //link to the CI_OnlineFunctionCode CodeList
        public string offLine__MD_Medium__name { get; set; } //link to the MD_MediumNameCode CodeList
        public string offLine__MD_Medium__density__Real { get; set; } //double greater than 0.0
        public string offLine__MD_Medium__densityUnits { get; set; }
        public string offLine__MD_Medium__volumes { get; set; }  //Int
        public string offLine__MD_Medium__mediumFormat { get; set; } //link to MD_MediumFormatCode Codelist
        public string offLine__MD_Medium__mediumNote { get; set; }

    }
    public class geographicExtentBoundingBox
    {
        public string Description { get; set; }
        public double NorthLat { get; set; }
        public double SouthLat { get; set; }
        public double WestLong { get; set; }
        public double EastLong { get; set; }
    }

    public class temporalElement__EX_TemporalExtent
    {
        //Potenialy coudl be a list.  Need to chose one
        public timePeriodExtent TimePeriod { get; set; }
        public timeInstantExtent TimeInstant { get; set; }
        
        //Maybe can set these to new for the one that gets implemented.  The other will be null, and not used
        //public temporalElement__EX_TemporalExtent()
        //{
        //    TimePeriod = new timePeriodExtent();
        //    TimeInstant = new timeInstantExtent();
        //}
    }

    [StructLayout(LayoutKind.Sequential)]
    public class timeInstantExtent
    {
        public string extent__TimeInstant__id { get; set; } //TimePeriod Attribute ID, unique for the set
        public string extent__TimeInstant__description { get; set; }
        public string extent__TimeInstant__timePosition { get; set; }        
        //handle indeterminatePosition: If timePosition not a date, then set the attribute to unknown, after, before, now
    }

    [StructLayout(LayoutKind.Sequential)]
    public class timePeriodExtent
    {
        public string extent__TimePeriod__id { get; set; }  //TimePeriod Attribute ID, unique for the set
        public string extent__TimePeriod__description { get; set; }
        public string extent__TimePeriod__beginPosition { get; set; }
        public string extent__TimePeriod__endPosition { get; set; }
        public string extent__TimePeriod__timeInterval { get; set; }
        public string extent__TimePeriod__timeIntervalUnit { get; set; }
        //handle indeterminatePosition: If begin/end not a date, then set the attribute to unknown,after,before,now
    }
}
