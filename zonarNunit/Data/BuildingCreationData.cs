using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zonarNunit.Data
{
    public class BuildingCreationData 
    {
        //test
        // Zoning Allowances Result Table 
        public string lotArea = "Lot Area";
        public string lotAreaMask = "*,*ft²";

        public string lotAreaInAcres = "Lot Area in Acres";
        public string lotAreaInAcresMask = "*.*acres";


        public string dwellingUnitsPerAcre = "Dwelling Units per Acre";
        public string dwellingUnitsPerAcreMask = "*du/acre";


        public string dwellingUnitsDUAllowed = "Dwelling Units (DU) Allowed";
        public string dwellingUnitsDUAllowedMask = "*du";


        public string far = "FAR";
        public string farMask = "*";

        public string lotCoverage = "Lot Coverage";
        public string lotCoverageMask = "*%";

        public string minOpenSpace = "Min Open Space";
        public string minOpenSpaceMask = "*%";

        public string principalBuildingHeightMax= "Principal Building Height Max.";
        public string principalBuildingHeightMaxMask = "*Levels";

        public string principalBuildingHeightMin = "Principal Building Height Min.";
        public string principalBuildingHeightMinMask = "*Levels";

        public string principalTowerHeight = "Principal Tower Height";
        public string principalTowerHeightMask = "*Levels";

        public string maximumBuiltArea = "Maximum Built Area";
        public string maximumBuiltAreaMask = "*ft²";


        public string maxBuildingArea = "Max Building Area";
        public string maxBuildingAreaMask = "*ft²";


        public string maximumBuildingFootprint = "Maximum Building Footprint";
        public string maximumBuildingFootprintMask = "*ft²";


        public string maximumOfficeArea = "Maximum Office Area";
        public string maximumOfficeAreaMask = "*ft²";

        public string maximumOfficeHeight = "Maximum Office Height";
        public string maximumOfficeHeightMask = "*Levels";

        public string maximumCommercialArea = "Maximum Commercial Area";
        public string maximumCommercialAreaMask = "*ft²";

        public string maximumCommercialHeight = "Maximum Commercial Height";
        public string maximumCommercialHeightMask = "*Levels";

        public string maxCommercialEstablishmentArea = "Max Commercial Establishment Area";
        public string maxCommercialEstablishmentAreaMask = "*ft²";



        // Capacity Analysis Result Table

        public string maxBuildingFootprint = "Max Building Footprint";
        public string maxBuildingFootprintMask = "*ft²";

        public string linerBuildingFootprint = "Liner Building Footprint";
        public string linerBuildingFootprintMask = "*ft²";


        public string residentalTowerFootprint = "Residental Tower Footprint";
        public string residentalTowerFootprintMask = "*ft²";


        public string commercialTowerFootprint = "Commercial Tower Footprint";
        public string commercialTowerFootprintMask = "*ft²";

        public string resultingLotCoverage = "Resulting Lot Coverage";
        public string resultingLotCoverageMask = "*%";

        public string totalBuildHeight = "Total Build Height";
        public string totalBuildHeightMask = "*totalBuildHeight";

        public string totalBuildArea = "Total Build Area";
        public string totalBuildAreaMask = "ft²";

        public string totalDwellingUnits = "Total Dwelling Units";
        public string totalDwellingUnitsMask = "*DU";

        public string residentialUnits = "Residential Units";
        public string residentialUnitsMask = "*";

        public string lodgingRooms = "Lodging Rooms";
        public string lodgingRoomsMask = "*";

        public string officeArea = "Office Area";
        public string officeAreaMask = "*ft²";

        public string assumedBuildingCommonSpaceArea = "Assumed Building Common Space Area";
        public string assumedBuildingCommonSpaceAreaMask = "*ft";




        //Residental Tower Footprint 14,400 ft²
        //Commercial Tower Footprint 14,400 ft²
        //Resulting Lot Coverage 80 %
        //Total Build Height 4 totalBuildHeight
        //Total Build Area 144,000 ft²
        //Total Dwelling Units 260 DU
        //Residential Units 100,000
        //Lodging Rooms 10,000
        //Office Area 5,000 ft²
        //Commercial Area 5,000 ft²
        //Assumed Building Common Space Area 24,000 ft
    }




    

}
