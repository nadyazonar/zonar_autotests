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
        public static BuildingCreationsParameters maimi1 = new BuildingCreationsParameters("150", "150", "Miami Base code", "T6", "48A", "Open");
       

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
        public static MaximumLotCapacity maimi = new MaximumLotCapacity("90,000 ft²", "2.067 acres", "150 du/acre", "310 DU",
            "11", "80 %", "10 %", "8 Levels", "2 Levels", "48 Levels", "990,000 ft²", "990,000 ft²");

        public static MaximumLotCapacity maimi1 = new MaximumLotCapacity("90,000 ft²", "2.067 acres", "150 du/acre", "310 DU",
            "11", "80 %", "10 %", "8 Levels", "2 Levels", "48 Levels", "990,000 ft²", "990,000 ft²");


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
        public static MaximumLotCapacity maximumLotCapacity = new MaximumLotCapacity("Lot Area Net", "Lot Area Acres", "Residential Density", "DU Allowed", "FAR",
                "Lot Coverage", "Min Open Space", "Principal Building Max Height", "Principal Building Min Height", "Principal Tower Height", "Max Built Area", "Max Building Area");


        
    }
    
    



}
