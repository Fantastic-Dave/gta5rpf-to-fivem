1998 Audi S8 (D2/PFL/US-Spec)
----------------------------------------------------------------------------------------------------
Audi A8 model source: Максим Яровой
Overall improvements, model/texture work, S8-conversion: HRH 
Specific parts: Turn10 (FM4,FH3), RVH Customs
Handling: wanted188
Conversion into GTAV: HRH
----------------------------------------------------------------------------------------------------
This mod should be the first D2 chassis Audi ever made for GTAV. Model is yet again from GTASA-era and it needed a lot of work to even get in this state, because interior initially didn´t exist. 
What is initally a pre-facelift A8 6.0, is redone by pictures and information to S8-spec (some FL-specific parts though).
Features most visual aspects & charateristics of this fantastic vehicle! Custom handling is most enjoyable behind steering wheel and manual gearbox.
For real enthusiasts, this car is actually presented in rare manual gearbox configuration + many factory options, such as "Navigation Plus System", "Bose Surround System" & etc.

This modification should have all the basic features of the game. I am not aware of any obvious bug apart from problems with bullet reactions (as all my mods do).

Paint list:
1. Exterior body paint.
2. Interior primary leather trim.
4. Paintable stock rims.
6. Interior secondary leather trim.
7. Dials. Keep white color for red S-needles.

Extra list:
EXTRA_1 - Front license plate.
EXTRA_2 - "S8" front grill badge.
EXTRA_3 - "S8" boot badge.
EXTRA_4 - Optional "quattro" boot badge.
EXTRA_5 - GPS-antenna for Navigation Plus.
EXTRA_6 - "0000" front grill badge.

Tuning list:
- Factory lower black-trim removal. You can separately turn on front bumper, rear bumper and side skirts to make them appear in exterior paint.
- Double pipe double tip exhaust systems. Traditional or "DTM"-style mufflers.
- 1 tuning spoiler to complete the "bodypaint-bodykit" look.
- ALPINE 1500W RMS Subwoofer system, famous combination of 2x TYPE-R subwoofers + V12-amp.
- Engine and suspension tuning actually working.
----------------------------------------------------------------------------------------------------
How to install:
....................................................................................................
If this is your first time to install a car mod in GTAV, then please read this: https://forums.gta5-mods.com/topic/1451/tutorial-grand-theft-auto-v-modding-a-few-things-you-should-know (especially 3.paragraph).
....................................................................................................
Replace version:
1. Open Explorer and go to this mod´s "Replace" folder.
2. Open OPENIV and go to update/x64/dlcpacks/mpspecialraces/dlc.rpf/x64/levels/gta5/vehicles/mpspecialracesvehicles.rpf
3. Find "ruston.yft", "ruston.ytd" & "ruston_hi.yft" and replace them with the same 3 files from "Replace" folder.
4. Open "vehicles.meta" in update/x64/dlcpacks/mpspecialraces/dlc.rpf/common/data/levels/gta5
6. Use CTRL+F to search "ruston".
7. Replace following lines in game-file.
   <Item>
      <modelName>ruston</modelName>
      <txdName>ruston</txdName>
      <handlingId>RUSTON</handlingId>
      <gameName>S8D2</gameName>
      <vehicleMakeName>AUDI</vehicleMakeName>
      <expressionDictName>null</expressionDictName>
      <expressionName>null</expressionName>
      <animConvRoofDictName />
	    <animConvRoofName />
      <animConvRoofWindowsAffected />
      <ptfxAssetName>null</ptfxAssetName>
      <audioNameHash>GAUNTLET2</audioNameHash>
      <layout>LAYOUT_STANDARD</layout>
      <coverBoundOffsets>WINDSOR2_COVER_OFFSET_INFO</coverBoundOffsets>
      <explosionInfo>EXPLOSION_INFO_DEFAULT</explosionInfo>
      <scenarioLayout />
      <cameraName>DEFAULT_FOLLOW_VEHICLE_CAMERA</cameraName>
      <aimCameraName>DEFAULT_THIRD_PERSON_VEHICLE_AIM_CAMERA</aimCameraName>
      <bonnetCameraName>VEHICLE_BONNET_CAMERA_STANDARD_LONG</bonnetCameraName>
      <povCameraName>REDUCED_NEAR_CLIP_POV_CAMERA</povCameraName>
      <FirstPersonDriveByIKOffset x="0.000000" y="-0.055000" z="-0.060000" />
      <FirstPersonDriveByUnarmedIKOffset x="0.000000" y="-0.025000" z="0.000000" />
	  <FirstPersonProjectileDriveByIKOffset x="0.000000" y="0.000000" z="-0.040000" />
	  <FirstPersonProjectileDriveByPassengerIKOffset x="0.000000" y="0.000000" z="-0.040000" />
	  <FirstPersonProjectileDriveByRearLeftIKOffset x="0.000000" y="0.000000" z="0.000000" />
	  <FirstPersonProjectileDriveByRearRightIKOffset x="0.000000" y="0.000000" z="0.000000" />
	  <FirstPersonDriveByLeftPassengerIKOffset x="0.000000" y="-0.015000" z="0.000000" />
	  <FirstPersonDriveByRightPassengerIKOffset x="0.000000" y="-0.055000" z="-0.060000" />
	  <FirstPersonDriveByRightRearPassengerIKOffset x="0.000000" y="0.000000" z="0.000000" />
	  <FirstPersonDriveByLeftPassengerUnarmedIKOffset x="0.000000" y="0.000000" z="0.000000" />
	  <FirstPersonDriveByRightPassengerUnarmedIKOffset x="0.000000" y="0.000000" z="0.000000" />
	  <FirstPersonMobilePhoneOffset x="0.150000" y="0.208000" z="0.546000" />
      <FirstPersonPassengerMobilePhoneOffset x="0.158000" y="0.135000" z="0.460000" />
	  <FirstPersonMobilePhoneSeatIKOffset>
		<Item>
			<Offset x="0.158000" y="0.000000" z="0.460000" />
			<SeatIndex value="2" />
		</Item>
		<Item>
			<Offset x="0.158000" y="0.000000" z="0.460000" />
			<SeatIndex value="3" />
		</Item>
	  </FirstPersonMobilePhoneSeatIKOffset>
      <PovCameraOffset x="0.000000" y="-0.185000" z="0.680000" />
      <PovCameraVerticalAdjustmentForRollCage value="0.000000" />
      <PovPassengerCameraOffset x="0.000000" y="0.000000" z="0.000000" />
	  <PovRearPassengerCameraOffset x="0.000000" y="-0.175000" z="0.000000" />
      <vfxInfoName>VFXVEHICLEINFO_CAR_GENERIC</vfxInfoName>
      <shouldUseCinematicViewMode value="true" />
      <shouldCameraTransitionOnClimbUpDown value="false" />
      <shouldCameraIgnoreExiting value="false" />
      <AllowPretendOccupants value="true" />
      <AllowJoyriding value="true" />
      <AllowSundayDriving value="true" />
      <AllowBodyColorMapping value="true" />
      <wheelScale value="0.309700" />
      <wheelScaleRear value="0.309700" />
      <dirtLevelMin value="0.000000" />
      <dirtLevelMax value="0.450000" />
      <envEffScaleMin value="0.000000" />
      <envEffScaleMax value="1.000000" />
      <envEffScaleMin2 value="0.000000" />
      <envEffScaleMax2 value="1.000000" />
      <damageMapScale value="0.400000" />
      <damageOffsetScale value="0.400000" />
      <diffuseTint value="0x00FFFFFF" />
      <steerWheelMult value="0.700000" />
      <HDTextureDist value="5.000000" />
      <lodDistances content="float_array">
        450.000000
        475.000000
        500.000000
        500.000000
        500.000000
        500.000000
      </lodDistances>
      <minSeatHeight value="0.925" />
      <identicalModelSpawnDistance value="150" />
      <maxNumOfSameColor value="2" />
      <defaultBodyHealth value="1000.000000" />
      <pretendOccupantsScale value="1.000000" />
      <visibleSpawnDistScale value="1.000000" />
      <trackerPathWidth value="2.000000" />
      <weaponForceMult value="1.000000" />
      <frequency value="10" />
      <swankness>SWANKNESS_3</swankness>
      <maxNum value="3" />
      <flags>FLAG_EXTRAS_REQUIRE FLAG_PARKING_SENSORS FLAG_RICH_CAR FLAG_INCREASE_PED_COMMENTS FLAG_EXTRAS_STRONG FLAG_PEDS_CAN_STAND_ON_TOP FLAG_USE_FAT_INTERIOR_LIGHT FLAG_USE_LIGHTING_INTERIOR_OVERRIDE</flags>
      <type>VEHICLE_TYPE_CAR</type>
      <plateType>VPT_FRONT_AND_BACK_PLATES</plateType>
	  <dashboardType>VDT_ZTYPE</dashboardType>
      <vehicleClass>VC_SEDAN</vehicleClass>
      <wheelType>VWT_HIEND</wheelType>
      <trailers />
      <additionalTrailers />
      <drivers />
      <extraIncludes>
        <Item>EXTRA_2 EXTRA_3</Item>
      </extraIncludes>
      <doorsWithCollisionWhenClosed />
      <driveableDoors />
      <bumpersNeedToCollideWithMap value="true" />
      <needsRopeTexture value="false" />
      <requiredExtras>EXTRA_6</requiredExtras>
      <rewards />
      <cinematicPartCamera>
        <Item>WHEEL_FRONT_RIGHT_CAMERA</Item>
        <Item>WHEEL_FRONT_LEFT_CAMERA</Item>
        <Item>WHEEL_REAR_RIGHT_CAMERA</Item>
        <Item>WHEEL_REAR_LEFT_CAMERA</Item>
      </cinematicPartCamera>
      <NmBraceOverrideSet />
      <buoyancySphereOffset x="0.000000" y="0.000000" z="0.000000" />
      <buoyancySphereSizeScale value="1.000000" />
      <pOverrideRagdollThreshold type="NULL" />
	  <firstPersonDrivebyData>
        <Item>STD_FUTO_FRONT_LEFT</Item>
        <Item>STD_FUTO_FRONT_RIGHT</Item>
        <Item>STD_WINDSOR2_REAR_LEFT</Item>
        <Item>STD_WINDSOR2_REAR_RIGHT</Item>
      </firstPersonDrivebyData>
    </Item> 
8. Open "handling.meta" in update/x64/dlcpacks/mpspecialraces/dlc.rpf/common/data
9. Use CTRL+F to find "RUSTON"
10. Replace following lines in game-file:
    <Item type="CHandlingData">
      <handlingName>RUSTON</handlingName>
      <fMass value="1900.000000" />
      <fInitialDragCoeff value="1.600000" />
      <fPercentSubmerged value="85.000000" />
      <vecCentreOfMassOffset x="0.000000" y="0.050000" z="0.00000" />
      <vecInertiaMultiplier x="1.300000" y="1.500000" z="1.200000" />
      <fDriveBiasFront value="0.500000" />
      <nInitialDriveGears value="6" />
      <fInitialDriveForce value="0.206000" />
      <fDriveInertia value="2.300000" />
      <fClutchChangeRateScaleUpShift value="2.950000" />
      <fClutchChangeRateScaleDownShift value="2.900000" />
      <fInitialDriveMaxFlatVel value="214.000000" />
      <fBrakeForce value="0.3000000" />
      <fBrakeBiasFront value="0.590000" />
      <fHandBrakeForce value="0.550000" />
      <fSteeringLock value="33.000000" />
      <fTractionCurveMax value="1.88000" />
      <fTractionCurveMin value="1.745000" />
      <fTractionCurveLateral value="18.500000" />
      <fTractionSpringDeltaMax value="1.000000" />
      <fLowSpeedTractionLossMult value="1.10000" />
      <fCamberStiffnesss value="0.000000" />
      <fTractionBiasFront value="0.490000" />
      <fTractionLossMult value="1.00000" />
      <fSuspensionForce value="3.400000" />
      <fSuspensionCompDamp value="1.700000" />
      <fSuspensionReboundDamp value="2.800000" />
      <fSuspensionUpperLimit value="0.100000" />
      <fSuspensionLowerLimit value="-0.100000" />
      <fSuspensionRaise value="0.000000" />
      <fSuspensionBiasFront value="0.570000" />
      <fAntiRollBarForce value="0.7500000" />
      <fAntiRollBarBiasFront value="0.600000" />
      <fRollCentreHeightFront value="0.130000" />
      <fRollCentreHeightRear value="0.130000" />
      <fCollisionDamageMult value="0.500000" />
      <fWeaponDamageMult value="1.000000" />
      <fDeformationDamageMult value="0.400000" />
      <fEngineDamageMult value="0.7000000" />
      <fPetrolTankVolume value="80.000000" />
      <fOilVolume value="15.000000" />
      <fSeatOffsetDistX value="0.000000" />
      <fSeatOffsetDistY value="0.000000" />
      <fSeatOffsetDistZ value="0.000000" />
      <nMonetaryValue value="20000" />
      <strModelFlags>440010</strModelFlags>
      <strHandlingFlags>20002</strHandlingFlags>
      <strDamageFlags>0</strDamageFlags>
      <AIHandling>SPORTS_CAR</AIHandling>
      <SubHandlingData>
        <Item type="CCarHandlingData">
          <fBackEndPopUpCarImpulseMult value="0.100000" />
          <fBackEndPopUpBuildingImpulseMult value="0.030000" />
          <fBackEndPopUpMaxDeltaSpeed value="0.600000" />
        </Item>
        <Item type="NULL" />
        <Item type="NULL" />
      </SubHandlingData>
    </Item>
11. Open "carvariations.meta" in update/x64/dlcpacks/mpspecialraces/dlc.rpf/common/data
12. Use CTRL+F to find "RUSTON"
13. Replace following lines in game-file.
    <Item>
      <modelName>ruston</modelName>
      <colors>
		     <Item>
          <indices content="char_array">
            28
            132
            0
            156
            22
            132
          </indices>
          <liveries>
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
          </liveries>
        </Item> 
        <Item>
          <indices content="char_array">
            112
            22
            122
            156
            22
            132
          </indices>
          <liveries>
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
          </liveries>
        </Item>    
			  <Item>
          <indices content="char_array">
            11
            107
            22
            156
            106
            134
          </indices>
          <liveries>
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
          </liveries>
        </Item>
				<Item>
          <indices content="char_array">
            73
            112
            0
            156
            121
            132
          </indices>
          <liveries>
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
            <Item value="false" />
          </liveries>
        </Item>     
      </colors>
      <kits>
        <Item>217_ruston_modkit</Item>
      </kits>
      <windowsWithExposedEdges />
      <plateProbabilities>
        <Probabilities>
          <Item>
            <Name>Standard White</Name>
            <Value value="100" />
          </Item>
        </Probabilities>
      </plateProbabilities>
      <lightSettings value="110" />
      <sirenSettings value="0" />
    </Item>
13. Replace all files from "Tuning" folder with files in update/x64/dlcpacks/mpspecialraces/dlc.rpf/x64/levels/mpspecialraces/vehiclemods/ruston_mods.rpf
14. Open "carcols.meta" in update/x64/dlcpacks/mpspecialraces/dlc.rpf/common/data
15. Use CTRL+F to find "RUSTON"
16. Replace following lines in game-file.
    <Item>
      <kitName>217_ruston_modkit</kitName>
      <id value="217" />	 	  
      <kitType>MKT_SPECIAL</kitType>
      <visibleMods>
			<Item>
          <modelName>rust_boot_a</modelName>
          <modShopLabel>RUST_BOOT1</modShopLabel>
          <linkedModels />
          <turnOffBones />
          <type>VMT_INTERIOR2</type>
          <bone>chassis</bone>
          <collisionBone>chassis</collisionBone>
          <cameraPos>VMCP_DEFAULT</cameraPos>
          <audioApply value="1.000000" />
          <weight value="20" />
          <turnOffExtra value="false" />
          <disableBonnetCamera value="false" />
          <allowBonnetSlide value="true" />
        </Item>
         <Item>
          <modelName>rust_wing_a</modelName>
          <modShopLabel>MNU_WING3</modShopLabel>
          <linkedModels />
          <turnOffBones />
          <type>VMT_SPOILER</type>
          <bone>boot</bone>
          <collisionBone>boot</collisionBone>
          <cameraPos>VMCP_DEFAULT</cameraPos>
          <audioApply value="1.000000" />
          <weight value="20" />
          <turnOffExtra value="false" />
          <disableBonnetCamera value="false" />
          <allowBonnetSlide value="true" />
		 </Item>
		 <Item>
          <modelName>rust_skirt_a</modelName>
          <modShopLabel>RUST_SKIRT1</modShopLabel>
          <linkedModels>
					  <Item>rust_door_dside_f</Item>
						<Item>rust_door_dside_r</Item>
						<Item>rust_door_pside_f</Item>
						<Item>rust_door_pside_r</Item>
          </linkedModels>
					<turnOffBones>
            <Item>misc_j</Item>
						<Item>misc_l</Item>
						<Item>misc_m</Item>
						<Item>misc_n</Item>
						<Item>misc_o</Item>     
          </turnOffBones>
          <type>VMT_SKIRT</type>
          <bone>chassis</bone>
          <collisionBone>chassis</collisionBone>
          <cameraPos>VMCP_DEFAULT</cameraPos>
          <audioApply value="1.000000" />
          <weight value="20" />
          <turnOffExtra value="false" />
          <disableBonnetCamera value="false" />
          <allowBonnetSlide value="true" />
         </Item>               		
         <Item>
          <modelName>rust_exhaust_a</modelName>
          <modShopLabel>RUST_EXH1</modShopLabel>
          <linkedModels />       
          <turnOffBones>
          <Item>misc_h</Item> 
          <Item>misc_e</Item> 
				  <Item>misc_i</Item> 
          </turnOffBones>
          <type>VMT_EXHAUST</type>
          <bone>chassis</bone>
          <collisionBone>chassis</collisionBone>
          <cameraPos>VMCP_DEFAULT</cameraPos>
          <audioApply value="1.000000" />
          <weight value="20" />
          <turnOffExtra value="false" />
          <disableBonnetCamera value="false" />
          <allowBonnetSlide value="true" />
         </Item>                   		
         <Item>
          <modelName>rust_exhaust_b</modelName>
          <modShopLabel>RUST_EXH2</modShopLabel>
          <linkedModels />                
          <turnOffBones>
          <Item>misc_h</Item> 
          <Item>misc_e</Item> 
				  <Item>misc_i</Item>
				  <Item>exhaust</Item> 
			    <Item>exhaust_2</Item>  
          </turnOffBones>
          <type>VMT_EXHAUST</type>
          <bone>chassis</bone>
          <collisionBone>chassis</collisionBone>
          <cameraPos>VMCP_DEFAULT</cameraPos>
          <audioApply value="1.000000" />
          <weight value="20" />
          <turnOffExtra value="false" />
          <disableBonnetCamera value="false" />
          <allowBonnetSlide value="true" />
         </Item>                 		                  		
	     <Item>
          <modelName>rust_bumf_a</modelName>
		  <modShopLabel>RUST_BUMPF1</modShopLabel>
          <linkedModels /> 
          <turnOffBones>
			<Item>misc_k</Item>
		  </turnOffBones>
          <type>VMT_BUMPER_F</type>
          <bone>bumper_f</bone>
          <collisionBone>bumper_f</collisionBone>
          <cameraPos>VMCP_DEFAULT</cameraPos>
          <audioApply value="1.000000" />
          <weight value="20" />
          <turnOffExtra value="false" />
          <disableBonnetCamera value="false" />
          <allowBonnetSlide value="false" />
         </Item>
	     <Item>
          <modelName>rust_bumr_a</modelName>
          <modShopLabel>MNU_BUMR0</modShopLabel>
          <linkedModels />         
          <turnOffBones>
            <Item>bumper_r</Item>
						<Item>misc_e</Item>
						<Item>misc_h</Item> 
          </turnOffBones> 
          <type>VMT_BUMPER_R</type>
          <bone>bumper_r</bone>
          <collisionBone>chassis</collisionBone>
          <cameraPos>VMCP_DEFAULT</cameraPos>
          <audioApply value="1.000000" />
          <weight value="20" />
          <turnOffExtra value="false" />
          <disableBonnetCamera value="false" />
          <allowBonnetSlide value="true" />
         </Item>
      </visibleMods>
       <linkMods>
		<Item>
			<modelName>rust_door_dside_f</modelName>
			<bone>door_dside_f</bone>
			<turnOffExtra value="false" />
		</Item>
		<Item>
			<modelName>rust_door_dside_r</modelName>
			<bone>door_dside_r</bone>
			<turnOffExtra value="false" />
		</Item>
		<Item>
			<modelName>rust_door_pside_f</modelName>
			<bone>door_pside_f</bone>
			<turnOffExtra value="false" />
		</Item>
		<Item>
			<modelName>rust_door_pside_r</modelName>
			<bone>door_pside_r</bone>
			<turnOffExtra value="false" />
		</Item>
			 </linkMods>
      <statMods>
        <Item>
          <identifier />
          <modifier value="150" />
          <audioApply value="1.000000" />
          <weight value="20" />
          <type>VMT_ENGINE</type>
        </Item>
        <Item>
          <identifier />
          <modifier value="250" />
          <audioApply value="1.000000" />
          <weight value="20" />
          <type>VMT_ENGINE</type>
        </Item>
        <Item>
          <identifier />
          <modifier value="350" />
          <audioApply value="1.000000" />
          <weight value="20" />
          <type>VMT_ENGINE</type>
        </Item>
        <Item>
          <identifier />
          <modifier value="500" />
          <audioApply value="1.000000" />
          <weight value="20" />
          <type>VMT_ENGINE</type>
        </Item>
        <Item>
          <identifier />
          <modifier value="25" />
          <audioApply value="1.000000" />
          <weight value="5" />
          <type>VMT_BRAKES</type>
        </Item>
        <Item>
          <identifier />
          <modifier value="65" />
          <audioApply value="1.000000" />
          <weight value="5" />
          <type>VMT_BRAKES</type>
        </Item>
        <Item>
          <identifier />
          <modifier value="100" />
          <audioApply value="1.000000" />
          <weight value="5" />
          <type>VMT_BRAKES</type>
        </Item>
        <Item>
          <identifier />
          <modifier value="25" />
          <audioApply value="1.000000" />
          <weight value="5" />
          <type>VMT_GEARBOX</type>
        </Item>
        <Item>
          <identifier />
          <modifier value="50" />
          <audioApply value="1.000000" />
          <weight value="5" />
          <type>VMT_GEARBOX</type>
        </Item>
        <Item>
          <identifier />
          <modifier value="100" />
          <audioApply value="1.000000" />
          <weight value="5" />
          <type>VMT_GEARBOX</type>
        </Item>
				<Item>
          <identifier />
          <modifier value="25" />
          <audioApply value="1.000000" />
          <weight value="5" />
          <type>VMT_SUSPENSION</type>
        </Item>
				<Item>
          <identifier />
          <modifier value="50" />
          <audioApply value="1.000000" />
          <weight value="5" />
          <type>VMT_SUSPENSION</type>
        </Item>
				<Item>
          <identifier />
          <modifier value="65" />
          <audioApply value="1.000000" />
          <weight value="5" />
          <type>VMT_SUSPENSION</type>
        </Item>
				<Item>
          <identifier />
          <modifier value="85" />
          <audioApply value="1.000000" />
          <weight value="5" />
          <type>VMT_SUSPENSION</type>
        </Item>
        <Item>
          <identifier />
          <modifier value="20" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_ARMOUR</type>
        </Item>
        <Item>
          <identifier />
          <modifier value="40" />
          <audioApply value="1.000000" />
          <weight value="10" />
          <type>VMT_ARMOUR</type>
        </Item>
        <Item>
          <identifier />
          <modifier value="60" />
          <audioApply value="1.000000" />
          <weight value="20" />
          <type>VMT_ARMOUR</type>
        </Item>
        <Item>
          <identifier />
          <modifier value="80" />
          <audioApply value="1.000000" />
          <weight value="30" />
          <type>VMT_ARMOUR</type>
        </Item>
        <Item>
          <identifier />
          <modifier value="100" />
          <audioApply value="1.000000" />
          <weight value="40" />
          <type>VMT_ARMOUR</type>
        </Item>     
        <Item>
          <identifier>HORN_TRUCK</identifier>
          <modifier value="1766676233" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>HORN_COP</identifier>
          <modifier value="2904189469" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>HORN_CLOWN</identifier>
          <modifier value="2543206147" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>HORN_MUSICAL_1</identifier>
          <modifier value="1732399718" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>HORN_MUSICAL_2</identifier>
          <modifier value="2046162893" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>HORN_MUSICAL_3</identifier>
          <modifier value="2194999691" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>HORN_MUSICAL_4</identifier>
          <modifier value="2508304100" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>HORN_MUSICAL_5</identifier>
          <modifier value="3707223535" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
		<Item>
          <identifier>HORN_SAD_TROMBONE</identifier>
          <modifier value="632950117" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>MUSICAL_HORN_BUSINESS_1</identifier>
          <modifier value="3628534289" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>MUSICAL_HORN_BUSINESS_2</identifier>
          <modifier value="3892554122" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>MUSICAL_HORN_BUSINESS_3</identifier>
          <modifier value="4112892878" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>MUSICAL_HORN_BUSINESS_4</identifier>
          <modifier value="116877169" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>MUSICAL_HORN_BUSINESS_5</identifier>
          <modifier value="2684983719" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>MUSICAL_HORN_BUSINESS_6</identifier>
          <modifier value="2982690084" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
		</Item>
		<Item>
          <identifier>MUSICAL_HORN_BUSINESS_7</identifier>
          <modifier value="3203290992" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
		</Item>
		<Item>
          <identifier>DLC_BUSI2_C_MAJOR_NOTES_C0</identifier>
          <modifier value="771284519" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
		</Item>
		<Item>
          <identifier>DLC_BUSI2_C_MAJOR_NOTES_D0</identifier>
          <modifier value="2586621229" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
		</Item>
		<Item>
          <identifier>DLC_BUSI2_C_MAJOR_NOTES_E0</identifier>
          <modifier value="283386134" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
		</Item>
		<Item>
          <identifier>DLC_BUSI2_C_MAJOR_NOTES_F0</identifier>
          <modifier value="3884502400" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
		</Item>
		<Item>
          <identifier>DLC_BUSI2_C_MAJOR_NOTES_G0</identifier>
          <modifier value="265723083" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
		</Item>
		<Item>
          <identifier>DLC_BUSI2_C_MAJOR_NOTES_A0</identifier>
          <modifier value="1746883687" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
		</Item>
		<Item>
          <identifier>DLC_BUSI2_C_MAJOR_NOTES_B0</identifier>
          <modifier value="1919870950" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
		</Item>
		<Item>
          <identifier>DLC_BUSI2_C_MAJOR_NOTES_C1</identifier>
          <modifier value="1085277077" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
		</Item>
        <Item>
          <identifier>HIPSTER_HORN_1</identifier>
          <modifier value="444549672" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>HIPSTER_HORN_2</identifier>
          <modifier value="1603064898" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>HIPSTER_HORN_3</identifier>
          <modifier value="240366033" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>HIPSTER_HORN_4</identifier>
          <modifier value="960137118" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>INDEP_HORN_1</identifier>
          <modifier value="3572144790" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>INDEP_HORN_2</identifier>
          <modifier value="3801396714" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>INDEP_HORN_3</identifier>
          <modifier value="2843657151" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>INDEP_HORN_4</identifier>
          <modifier value="3341811489" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
        <Item>
          <identifier>LUXE_HORN_1</identifier>
          <modifier value="3199657341" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
    <Item>
          <identifier>LUXE_HORN_2</identifier>
          <modifier value="2900378064" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
    <Item>
          <identifier>LUXE_HORN_3</identifier>
          <modifier value="3956195248" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
		<!-- PREVIEW HORN - FOR MOD SHOP USE ONLY -->
		<Item>
          <identifier>LUXORY_HORN_1</identifier>
          <modifier value="676333254" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
		<!-- PREVIEW HORN - FOR MOD SHOP USE ONLY -->
		<Item>
          <identifier>LUXURY_HORN_2</identifier>
          <modifier value="2099578296" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
		<!-- PREVIEW HORN - FOR MOD SHOP USE ONLY -->
		<Item>
          <identifier>LUXURY_HORN_3</identifier>
          <modifier value="1373384483" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
		<Item>
          <identifier>ORGAN_HORN_LOOP_01</identifier>
          <modifier value="2916775806" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
		<!-- PREVIEW HORN - FOR MOD SHOP USE ONLY -->
		<Item>
          <identifier>ORGAN_HORN_LOOP_01_PREVIEW</identifier>
          <modifier value="3714706952" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
		<Item>
          <identifier>ORGAN_HORN_LOOP_02</identifier>
          <modifier value="2611860261" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
		<!-- PREVIEW HORN - FOR MOD SHOP USE ONLY -->
		<Item>
          <identifier>ORGAN_HORN_LOOP_02_PREVIEW</identifier>
          <modifier value="3206770359" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
		<Item>
          <identifier>LOWRIDER_HORN_1</identifier>
          <modifier value="310529291" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
		<!-- PREVIEW HORN - FOR MOD SHOP USE ONLY -->
		<Item>
          <identifier>LOWRIDER_HORN_1_PREVIEW</identifier>
          <modifier value="2965568987" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
		<Item>
          <identifier>LOWRIDER_HORN_2</identifier>
          <modifier value="55291550" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
		<!-- PREVIEW HORN - FOR MOD SHOP USE ONLY -->
		<Item>
          <identifier>LOWRIDER_HORN_2_PREVIEW</identifier>
          <modifier value="965054819" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
		<Item>
          <identifier>XM15_HORN_01</identifier>
          <modifier value="55862314" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
		<!-- PREVIEW HORN - FOR MOD SHOP USE ONLY -->
		<Item>
          <identifier>XM15_HORN_01_PREVIEW</identifier>
          <modifier value="2156743178" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>	
		<Item>
          <identifier>XM15_HORN_02</identifier>
          <modifier value="400002352" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
		<!-- PREVIEW HORN - FOR MOD SHOP USE ONLY -->
		<Item>
          <identifier>XM15_HORN_02_PREVIEW</identifier>
          <modifier value="897484282" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
		<Item>
          <identifier>XM15_HORN_03</identifier>
          <modifier value="560832604" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
		<!-- PREVIEW HORN - FOR MOD SHOP USE ONLY -->
		<Item>
          <identifier>XM15_HORN_03_PREVIEW</identifier>
          <modifier value="314232747" />
          <audioApply value="1.000000" />
          <weight value="0" />
          <type>VMT_HORN</type>
        </Item>
      </statMods>
      <slotNames>
        <Item>
          <slot>VMT_CHASSIS</slot>
          <name>TOP_CAGE</name>
        </Item>
        <Item>
          <slot>VMT_GRILL</slot>
          <name>TOP_SPLIT</name>
        </Item>	
      </slotNames>
      <liveryNames />
    </Item>  


!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
.....................................................................................
16. Scroll down for "lights"-section in carcols.meta and then replace these lines also...
.....................................................................................
!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


    <Item>
      <id value="110" />
      <indicator>
        <intensity value="0.375000" />
        <falloffMax value="2.500000" />
        <falloffExponent value="8.000000" />
        <innerConeAngle value="20.000000" />
        <outerConeAngle value="50.000000" />
        <emmissiveBoost value="true" />
        <color value="0xFFFF7300" />
        <textureName />
        <mirrorTexture value="false" />
      </indicator>
      <rearIndicatorCorona>
        <size value="0.500000" />
        <size_far value="0.800000" />
        <intensity value="0.500000" />
        <intensity_far value="0.800000" />
        <color value="0xFFFF7300" />
        <numCoronas value="1" />
        <distBetweenCoronas value="128" />
        <distBetweenCoronas_far value="255" />
        <xRotation value="0.000000" />
        <yRotation value="0.000000" />
        <zRotation value="0.000000" />
        <zBias value="0.250000" />
        <pullCoronaIn value="false" />
      </rearIndicatorCorona>
      <frontIndicatorCorona>
        <size value="0.500000" />
        <size_far value="0.500000" />
        <intensity value="0.500000" />
        <intensity_far value="0.800000" />
        <color value="0xFFFF7300" />
        <numCoronas value="1" />
        <distBetweenCoronas value="128" />
        <distBetweenCoronas_far value="255" />
        <xRotation value="0.000000" />
        <yRotation value="0.000000" />
        <zRotation value="0.000000" />
        <zBias value="0.250000" />
        <pullCoronaIn value="false" />
      </frontIndicatorCorona>
      <tailLight>
        <intensity value="0.50000"/>
        <falloffMax value="4.000000" />
        <falloffExponent value="16.000000" />
        <innerConeAngle value="45.000000" />
        <outerConeAngle value="90.000000" />
        <emmissiveBoost value="false" />
        <color value="0xFFFF0F05" />
        <textureName />
        <mirrorTexture value="false" />
      </tailLight>
      <tailLightCorona>
        <size value="0.00000000"/>
        <size_far value="0.00000000"/>
        <intensity value="0.00000000"/>
        <intensity_far value="0.00000000"/>
        <color value="0xFFFF0F05" />
        <numCoronas value="1" />
        <distBetweenCoronas value="1" />
        <distBetweenCoronas_far value="135" />
        <xRotation value="0.000000" />
        <yRotation value="0.000000" />
        <zRotation value="5.806000" />
        <zBias value="0.250000" />
        <pullCoronaIn value="false" />
      </tailLightCorona>
      <tailLightMiddleCorona>
        <size value="0.000000" />
        <size_far value="0.000000" />
        <intensity value="0.000000" />
        <intensity_far value="0.000000" />
        <color value="0x00000000" />
        <numCoronas value="1" />
        <distBetweenCoronas value="128" />
        <distBetweenCoronas_far value="255" />
        <xRotation value="0.000000" />
        <yRotation value="0.000000" />
        <zRotation value="0.000000" />
        <zBias value="0.250000" />
        <pullCoronaIn value="false" />
      </tailLightMiddleCorona>
      <headLight>
        <intensity value="2.500000" />
        <falloffMax value="20.000000" />
        <falloffExponent value="16.000000" />
        <innerConeAngle value="10.000000" />
        <outerConeAngle value="60.000000" />
        <emmissiveBoost value="true" />
        <color value="0xFF7FA7E3" />
        <textureName>VehicleLight_car_standardmodern</textureName>
        <mirrorTexture value="false" />
      </headLight>
      <headLightCorona>
        <size value="0.500000" />
        <size_far value="0.800000" />
        <intensity value="0.500000" />
        <intensity_far value="0.800000" />
        <color value="0xFF61A5FF" />
        <numCoronas value="1" />
        <distBetweenCoronas value="1" />
        <distBetweenCoronas_far value="210" />
        <xRotation value="0.000000" />
        <yRotation value="0.094000" />
        <zRotation value="1.005000" />
        <zBias value="0.250000" />
        <pullCoronaIn value="false" />
      </headLightCorona>
      <reversingLight>
        <intensity value="1.000000" />
        <falloffMax value="7.200000" />
        <falloffExponent value="32.000000" />
        <innerConeAngle value="20.000000" />
        <outerConeAngle value="78.000000" />
        <emmissiveBoost value="true" />
        <color value="0xFFFFFFFF" />
        <textureName />
        <mirrorTexture value="false" />
      </reversingLight>
      <reversingLightCorona>
        <size value="0.200000" />
        <size_far value="0.500000" />
        <intensity value="0.500000" />
        <intensity_far value="0.800000" />
        <color value="0x00F7F7F7" />
        <numCoronas value="1" />
        <distBetweenCoronas value="128" />
        <distBetweenCoronas_far value="255" />
        <xRotation value="0.000000" />
        <yRotation value="0.000000" />
        <zRotation value="0.000000" />
        <zBias value="0.250000" />
        <pullCoronaIn value="false" />
      </reversingLightCorona>
      <name>ruston</name>
    </Item>

17. DONE! Please remember to install it as add-on, because then You would even have custom real names for car and tuning parts, which is a lot easier to obtain there!

....................................................................................................
Add-on version:
1. Put folder "s8d2" into mods/update/x64/dlcpacks
2. Open "dlclist.xml" in update/update.rpf/common/data
3. Add line into the list:
    <Item>dlcpacks:\s8d2\</Item>
4. Save and put back inside update/update.rpf/common/data
5. Play the game and spawn with "s8d2"
----------------------------------------------------------------------------------------------------
It is recommended that you use OpenIV's "mods"-folder feature (http://openiv.com/?p=1132).
-----------------------------------------------------------------------------------------------------
SUPPORT THE DEVELOPER! PLEASE BUY THE GAME!
