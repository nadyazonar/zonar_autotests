using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zonarNunit.Data
{
    public class BuildingCreationsParameters
    {

        // input data
        public static BuildingCreationsParameters maimi = new BuildingCreationsParameters("300", "300", "Miami Base code", "T6", "48A", "Open");
        public static BuildingCreationsParameters maimi1 = new BuildingCreationsParameters("300", "300", "Miami Base code", "T6", "48A", "Open");
       

        public string Width { get; set; }
        public string Depth { get; set; }
        public string ZoningCode { get; set; }
        public string Type { get; set; }
        public string SubZone { get; set; }
        public string Zone { get; set; }



        
        public BuildingCreationsParameters(string width, string depth, string zoningCode, string zone, string subZone, string type)
        {
            Width = width;
            Depth = depth;
            ZoningCode = zoningCode;
            Zone = zone;
            Type = type;
            SubZone = subZone;

           
        }

    }

    public class MaximumLotCapacity
    {

        // Expected result
        public static MaximumLotCapacity maimi = new MaximumLotCapacity(
                                                                        "90,000 ft²",
                                                                        "2.067 acres",
                                                                        "150 du/acre",
                                                                        "310 DU",
                                                                        "11",
                                                                        "80 %",
                                                                        "10 %",
                                                                        "8 Levels",
                                                                        "2 Levels",
                                                                        "48 Levels",
                                                                        "990,000 ft²",
                                                                        "990,000 ft²");

        public static MaximumLotCapacity maimi1 = new MaximumLotCapacity(
                                                                        "90,000 ft²",
                                                                        "2.067 acres",
                                                                        "150 du/acre",
                                                                        "310 DU",
                                                                        "11",
                                                                        "80 %",
                                                                        "10 %",
                                                                        "8 Levels",
                                                                        "2 Levels",
                                                                        "48 Levels",
                                                                        "990,000 ft²",
                                                                        "990,000 ft²");


        public string LotAreaNet { get; set; }
        public string LotAreaAcres { get; set; }
        public string ResidentialDensity { get; set; }
        public string DUAllowed { get; set; }
        public string FAR { get; set; }
        public string LotCoverage { get; set; }
        public string MinOpenSpace { get; set; }
        public string PrincipalBuildingMaxHeight { get; set; }
        public string PrincipalBuildingMinHeight { get; set; }
        public string PrincipalTowerHeight { get; set; }
        public string MaxBuiltArea { get; set; }
        public string MaxBuildingArea { get; set; }
        public string[] BuildingCreationsParametersTemplateArray = new string[12];
        

        public MaximumLotCapacity(string lotAreaNet,                   string lotAreaAcres, 
                                                   string residentialDensity,           string dUAllowed,                    
                                                   string fAR,                          string lotCoverage,
                                                   string minOpenSpace,                 string principalBuildingMaxHeight, 
                                                   string principalBuildingMinHeight,   string principalTowerHeight, 
                                                   string maxBuiltArea,                 string maxBuildingArea)
        {

            BuildingCreationsParametersTemplateArray[0] = lotAreaNet;
            BuildingCreationsParametersTemplateArray[1] = lotAreaAcres;
            BuildingCreationsParametersTemplateArray[2] = residentialDensity;
            BuildingCreationsParametersTemplateArray[3] = dUAllowed;
            BuildingCreationsParametersTemplateArray[4] = fAR;
            BuildingCreationsParametersTemplateArray[5] = lotCoverage;
            BuildingCreationsParametersTemplateArray[6] = minOpenSpace;
            BuildingCreationsParametersTemplateArray[7] = principalBuildingMaxHeight;
            BuildingCreationsParametersTemplateArray[8] = principalBuildingMinHeight;
            BuildingCreationsParametersTemplateArray[9] = principalTowerHeight;
            BuildingCreationsParametersTemplateArray[10] = maxBuiltArea;
            BuildingCreationsParametersTemplateArray[11] = maxBuildingArea;
            


            LotAreaNet = lotAreaNet;
            LotAreaAcres = lotAreaAcres;
            ResidentialDensity = residentialDensity;
            DUAllowed = dUAllowed;
            FAR = fAR;
            LotCoverage = lotCoverage;
            MinOpenSpace = minOpenSpace;
            PrincipalBuildingMaxHeight = principalBuildingMaxHeight;
            PrincipalBuildingMinHeight = principalBuildingMinHeight;
            PrincipalTowerHeight = principalTowerHeight;
            MaxBuiltArea = maxBuildingArea;
            MaxBuildingArea = maxBuildingArea;
        }

        // fields names 
        public static MaximumLotCapacity maximumLotCapacity = new MaximumLotCapacity(
                                                                "Lot Area Net",
                                                                "Lot Area Acres",
                                                                "Residential Density",
                                                                "DU Allowed",
                                                                "FAR",
                                                                "Lot Coverage",
                                                                "Min Open Space",
                                                                "Principal Building Max Height",
                                                                "Principal Building Min Height",
                                                                "Principal Tower Height",
                                                                "Max Built Area",
                                                                "Max Building Area");


        
    }

    public class ResultCapacityAnalysis
    {


        // Expected result
        public static ResultCapacityAnalysis maimi = new ResultCapacityAnalysis(
                                                        "72,000 ft²",
                                                        "6,300 ft²",
                                                        "14,400 ft²",
                                                        "14,400 ft²",
                                                        "80 %",
                                                        "4 Levels",
                                                        "144,000 ft²",
                                                        "260 DU",
                                                        "100,000",
                                                        "10,000",
                                                        "5,000 ft²",
                                                        "5,000 ft²",
                                                        "24,000 ft²",
                                                        "N/A",
                                                        "N/A",
                                                        "420",
                                                        "N/A",
                                                        "420",
                                                        "239");
        //public static ResultCapacityAnalysis maimi = new ResultCapacityAnalysis(
        //                                                " 72,000 ft²",
        //                                                "Liner Building Footprint",
        //                                                "Residental Tower Footprint",
        //                                                "Commercial Tower Footprint",
        //                                                "Resulting Lot Coverage",
        //                                                "Total Build Height",
        //                                                "Total Build Area",
        //                                                "Total Dwelling Units",
        //                                                "Residential Units",
        //                                                "Lodging Rooms",
        //                                                "Office Area",
        //                                                "Commercial Area",
        //                                                "Assumed Building Common Space Area",
        //                                                "Max.On - Street Pkg Capacity",
        //                                                "Off - Site Parking",
        //                                                "Pkg.Structur",
        //                                                "Pkg.Underground",
        //                                                "Max.Lot Pkg Capacity",
        //                                                "Max.Shared Pkg Required");


        public string MaxBuildingFootprint { get; set; }
        public string LinerBuildingFootprint { get; set; }
        public string ResidentalTowerFootprint { get; set; }
        public string CommercialTowerFootprint { get; set; }
        public string ResultingLotCoverage { get; set; }
        public string TotalBuildHeight { get; set; }
        public string TotalBuildArea { get; set; }
        public string TotalDwellingUnits { get; set; }
        public string ResidentialUnits { get; set; }
        public string LodgingRooms { get; set; }
        public string OfficeArea { get; set; }
        public string CommercialArea { get; set; }
        public string AssumedBuildingCommonSpaceArea { get; set; }
        public string MaxOnStreetPkgCapacity { get; set; }
        public string OffSiteParking { get; set; }
        public string PkgStructure { get; set; }
        public string PkgUnderground { get; set; }
        public string MaxLotPkgCapacity { get; set; }
        public string MaxSharedPkgRequired { get; set; }

        public string[] ResultCapacityAnalysisArray = new string[19];

        public ResultCapacityAnalysis(string maxBuildingFootprint, string linerBuildingFootprint,
                                                   string residentalTowerFootprint, string commercialTowerFootprint,
                                                   string resultingLotCoverage, string totalBuildHeight,
                                                   string totalBuildArea, string totalDwellingUnits,
                                                   string residentialUnits, string lodgingRooms,
                                                   string officeArea, string commercialArea, string assumedBuildingCommonSpaceArea,
                                                   string maxOnStreetPkgCapacity, string offSiteParking, string pkgStructure, 
                                                   string pkgUnderground, string maxLotPkgCapacity, string maxSharedPkgRequired)
        {

            ResultCapacityAnalysisArray[0] = maxBuildingFootprint;
            ResultCapacityAnalysisArray[1] = linerBuildingFootprint;
            ResultCapacityAnalysisArray[2] = residentalTowerFootprint;
            ResultCapacityAnalysisArray[3] = commercialTowerFootprint;
            ResultCapacityAnalysisArray[4] = resultingLotCoverage;
            ResultCapacityAnalysisArray[5] = totalBuildHeight;
            ResultCapacityAnalysisArray[6] = totalBuildArea;
            ResultCapacityAnalysisArray[7] = totalDwellingUnits;
            ResultCapacityAnalysisArray[8] = residentialUnits;
            ResultCapacityAnalysisArray[9] = lodgingRooms;
            ResultCapacityAnalysisArray[10] = officeArea;
            ResultCapacityAnalysisArray[11] = commercialArea;
            ResultCapacityAnalysisArray[12] = assumedBuildingCommonSpaceArea;
            ResultCapacityAnalysisArray[13] = maxOnStreetPkgCapacity;
            ResultCapacityAnalysisArray[14] = offSiteParking;
            ResultCapacityAnalysisArray[15] = pkgStructure;
            ResultCapacityAnalysisArray[16] = pkgUnderground;
            ResultCapacityAnalysisArray[17] = maxLotPkgCapacity;
            ResultCapacityAnalysisArray[18] = maxSharedPkgRequired;
            



            MaxBuildingFootprint = maxBuildingFootprint;
            LinerBuildingFootprint = linerBuildingFootprint;
            ResidentalTowerFootprint = residentalTowerFootprint;
            CommercialTowerFootprint = commercialTowerFootprint;
            ResultingLotCoverage = ResultingLotCoverage;
            TotalBuildHeight = totalBuildHeight;
            TotalBuildArea = totalBuildArea;
            TotalDwellingUnits = totalDwellingUnits;
            ResidentialUnits = residentialUnits;
            LodgingRooms = lodgingRooms;
            OfficeArea = officeArea;
            CommercialArea = commercialArea;
            AssumedBuildingCommonSpaceArea = assumedBuildingCommonSpaceArea;
            MaxOnStreetPkgCapacity = maxOnStreetPkgCapacity;
            OffSiteParking = offSiteParking;
            PkgStructure = pkgStructure;
            PkgUnderground = pkgUnderground;
            MaxLotPkgCapacity = maxLotPkgCapacity;
            MaxSharedPkgRequired = maxSharedPkgRequired;
    }

        // fields names 
        public static ResultCapacityAnalysis resultCapacityAnalysis = new ResultCapacityAnalysis(
                                                        "Max Building Footprint",
                                                        "Liner Building Footprint",
                                                        "Residental Tower Footprint",
                                                        "Commercial Tower Footprint",
                                                        "Resulting Lot Coverage",
                                                        "Total Build Height",
                                                        "Total Build Area",
                                                        "Total Dwelling Units",
                                                        "Residential Units",
                                                        "Lodging Rooms",
                                                        "Office Area",
                                                        "Commercial Area",
                                                        "Assumed Building Common Space Area",
                                                        "Max. On-Street Pkg Capacity",
                                                        "Off-Site Parking",
                                                        "Pkg. Structure",
                                                        "Pkg. Underground",
                                                        "Max. Lot Pkg Capacity",
                                                        "Max. Shared Pkg Required");


    }
}






