namespace SpaceStrategy
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Planets = new System.Windows.Forms.ListBox();
            this.Colonies = new System.Windows.Forms.ListBox();
            this.Buildings = new System.Windows.Forms.ListBox();
            this.Units = new System.Windows.Forms.ListBox();
            this.StarShips = new System.Windows.Forms.ListBox();
            this.AddStarShip = new System.Windows.Forms.Button();
            this.ColonizePlanet = new System.Windows.Forms.Button();
            this.ChoosenPlanet = new System.Windows.Forms.ListBox();
            this.AddChoosenColony = new System.Windows.Forms.ListBox();
            this.AddChoosenBuilding = new System.Windows.Forms.ListBox();
            this.AddChoosenUnit = new System.Windows.Forms.ListBox();
            this.AddBuildingToColony = new System.Windows.Forms.Button();
            this.AddUnitToStarShip = new System.Windows.Forms.Button();
            this.AddColonyToStarShip = new System.Windows.Forms.Button();
            this.AddChoosenStarShip = new System.Windows.Forms.ListBox();
            this.StarShipColonies = new System.Windows.Forms.ListBox();
            this.StarShipUnits = new System.Windows.Forms.ListBox();
            this.AddUnitToColony = new System.Windows.Forms.Button();
            this.AddColonyToPlanet = new System.Windows.Forms.Button();
            this.PlanetResourses = new System.Windows.Forms.ListBox();
            this.ColonyResourses = new System.Windows.Forms.ListBox();
            this.BuildingResourses = new System.Windows.Forms.ListBox();
            this.UnitState = new System.Windows.Forms.ListBox();
            this.ChoosenBuilding = new System.Windows.Forms.ListBox();
            this.MoveUnitsToBuilding = new System.Windows.Forms.Button();
            this.MoveResoursesToBuilding = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Planets
            // 
            this.Planets.FormattingEnabled = true;
            this.Planets.Location = new System.Drawing.Point(12, 12);
            this.Planets.Name = "Planets";
            this.Planets.Size = new System.Drawing.Size(303, 160);
            this.Planets.Sorted = true;
            this.Planets.TabIndex = 0;
            this.Planets.SelectedIndexChanged += new System.EventHandler(this.Planets_SelectedIndexChanged);
            // 
            // Colonies
            // 
            this.Colonies.FormattingEnabled = true;
            this.Colonies.Location = new System.Drawing.Point(321, 12);
            this.Colonies.Name = "Colonies";
            this.Colonies.Size = new System.Drawing.Size(303, 160);
            this.Colonies.Sorted = true;
            this.Colonies.TabIndex = 1;
            this.Colonies.SelectedIndexChanged += new System.EventHandler(this.Colonies_SelectedIndexChanged);
            // 
            // Buildings
            // 
            this.Buildings.FormattingEnabled = true;
            this.Buildings.Location = new System.Drawing.Point(630, 12);
            this.Buildings.Name = "Buildings";
            this.Buildings.Size = new System.Drawing.Size(303, 160);
            this.Buildings.Sorted = true;
            this.Buildings.TabIndex = 2;
            this.Buildings.SelectedIndexChanged += new System.EventHandler(this.Buildings_SelectedIndexChanged);
            // 
            // Units
            // 
            this.Units.FormattingEnabled = true;
            this.Units.Location = new System.Drawing.Point(939, 12);
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(303, 160);
            this.Units.Sorted = true;
            this.Units.TabIndex = 3;
            this.Units.SelectedIndexChanged += new System.EventHandler(this.Units_SelectedIndexChanged);
            // 
            // StarShips
            // 
            this.StarShips.FormattingEnabled = true;
            this.StarShips.Location = new System.Drawing.Point(12, 344);
            this.StarShips.Name = "StarShips";
            this.StarShips.Size = new System.Drawing.Size(303, 160);
            this.StarShips.Sorted = true;
            this.StarShips.TabIndex = 5;
            this.StarShips.SelectedIndexChanged += new System.EventHandler(this.StarShips_SelectedIndexChanged);
            // 
            // AddStarShip
            // 
            this.AddStarShip.Location = new System.Drawing.Point(218, 645);
            this.AddStarShip.Name = "AddStarShip";
            this.AddStarShip.Size = new System.Drawing.Size(200, 25);
            this.AddStarShip.TabIndex = 6;
            this.AddStarShip.Text = "Add StarShip";
            this.AddStarShip.UseVisualStyleBackColor = true;
            // 
            // ColonizePlanet
            // 
            this.ColonizePlanet.Location = new System.Drawing.Point(836, 645);
            this.ColonizePlanet.Name = "ColonizePlanet";
            this.ColonizePlanet.Size = new System.Drawing.Size(200, 25);
            this.ColonizePlanet.TabIndex = 7;
            this.ColonizePlanet.Text = "Colonize Planet";
            this.ColonizePlanet.UseVisualStyleBackColor = true;
            // 
            // ChoosenPlanet
            // 
            this.ChoosenPlanet.FormattingEnabled = true;
            this.ChoosenPlanet.Location = new System.Drawing.Point(836, 676);
            this.ChoosenPlanet.Name = "ChoosenPlanet";
            this.ChoosenPlanet.Size = new System.Drawing.Size(200, 160);
            this.ChoosenPlanet.Sorted = true;
            this.ChoosenPlanet.TabIndex = 8;
            this.ChoosenPlanet.SelectedIndexChanged += new System.EventHandler(this.ChoosenPlanet_SelectedIndexChanged);
            // 
            // AddChoosenColony
            // 
            this.AddChoosenColony.FormattingEnabled = true;
            this.AddChoosenColony.Location = new System.Drawing.Point(12, 676);
            this.AddChoosenColony.Name = "AddChoosenColony";
            this.AddChoosenColony.Size = new System.Drawing.Size(200, 160);
            this.AddChoosenColony.Sorted = true;
            this.AddChoosenColony.TabIndex = 9;
            this.AddChoosenColony.SelectedIndexChanged += new System.EventHandler(this.AddChoosenColony_SelectedIndexChanged);
            // 
            // AddChoosenBuilding
            // 
            this.AddChoosenBuilding.FormattingEnabled = true;
            this.AddChoosenBuilding.Location = new System.Drawing.Point(424, 676);
            this.AddChoosenBuilding.Name = "AddChoosenBuilding";
            this.AddChoosenBuilding.Size = new System.Drawing.Size(200, 160);
            this.AddChoosenBuilding.Sorted = true;
            this.AddChoosenBuilding.TabIndex = 10;
            this.AddChoosenBuilding.SelectedIndexChanged += new System.EventHandler(this.AddChoosenBuilding_SelectedIndexChanged);
            // 
            // AddChoosenUnit
            // 
            this.AddChoosenUnit.FormattingEnabled = true;
            this.AddChoosenUnit.Location = new System.Drawing.Point(630, 676);
            this.AddChoosenUnit.Name = "AddChoosenUnit";
            this.AddChoosenUnit.Size = new System.Drawing.Size(200, 160);
            this.AddChoosenUnit.Sorted = true;
            this.AddChoosenUnit.TabIndex = 11;
            this.AddChoosenUnit.SelectedIndexChanged += new System.EventHandler(this.AddChoosenUnit_SelectedIndexChanged);
            // 
            // AddBuildingToColony
            // 
            this.AddBuildingToColony.Location = new System.Drawing.Point(424, 645);
            this.AddBuildingToColony.Name = "AddBuildingToColony";
            this.AddBuildingToColony.Size = new System.Drawing.Size(200, 25);
            this.AddBuildingToColony.TabIndex = 12;
            this.AddBuildingToColony.Text = "Add Building to Colony";
            this.AddBuildingToColony.UseVisualStyleBackColor = true;
            // 
            // AddUnitToStarShip
            // 
            this.AddUnitToStarShip.Location = new System.Drawing.Point(630, 614);
            this.AddUnitToStarShip.Name = "AddUnitToStarShip";
            this.AddUnitToStarShip.Size = new System.Drawing.Size(200, 25);
            this.AddUnitToStarShip.TabIndex = 13;
            this.AddUnitToStarShip.Text = "Add Unit to StarShip";
            this.AddUnitToStarShip.UseVisualStyleBackColor = true;
            // 
            // AddColonyToStarShip
            // 
            this.AddColonyToStarShip.Location = new System.Drawing.Point(12, 616);
            this.AddColonyToStarShip.Name = "AddColonyToStarShip";
            this.AddColonyToStarShip.Size = new System.Drawing.Size(200, 25);
            this.AddColonyToStarShip.TabIndex = 14;
            this.AddColonyToStarShip.Text = "Add Colony to StarShip";
            this.AddColonyToStarShip.UseVisualStyleBackColor = true;
            // 
            // AddChoosenStarShip
            // 
            this.AddChoosenStarShip.FormattingEnabled = true;
            this.AddChoosenStarShip.Location = new System.Drawing.Point(218, 676);
            this.AddChoosenStarShip.Name = "AddChoosenStarShip";
            this.AddChoosenStarShip.Size = new System.Drawing.Size(200, 160);
            this.AddChoosenStarShip.Sorted = true;
            this.AddChoosenStarShip.TabIndex = 16;
            this.AddChoosenStarShip.SelectedIndexChanged += new System.EventHandler(this.AddChoosenStarShip_SelectedIndexChanged);
            // 
            // StarShipColonies
            // 
            this.StarShipColonies.FormattingEnabled = true;
            this.StarShipColonies.Location = new System.Drawing.Point(321, 344);
            this.StarShipColonies.Name = "StarShipColonies";
            this.StarShipColonies.Size = new System.Drawing.Size(303, 160);
            this.StarShipColonies.Sorted = true;
            this.StarShipColonies.TabIndex = 17;
            this.StarShipColonies.SelectedIndexChanged += new System.EventHandler(this.StarShipColonies_SelectedIndexChanged);
            // 
            // StarShipUnits
            // 
            this.StarShipUnits.FormattingEnabled = true;
            this.StarShipUnits.Location = new System.Drawing.Point(630, 344);
            this.StarShipUnits.Name = "StarShipUnits";
            this.StarShipUnits.Size = new System.Drawing.Size(303, 160);
            this.StarShipUnits.Sorted = true;
            this.StarShipUnits.TabIndex = 18;
            this.StarShipUnits.SelectedIndexChanged += new System.EventHandler(this.StarShipUnits_SelectedIndexChanged);
            // 
            // AddUnitToColony
            // 
            this.AddUnitToColony.Location = new System.Drawing.Point(630, 645);
            this.AddUnitToColony.Name = "AddUnitToColony";
            this.AddUnitToColony.Size = new System.Drawing.Size(200, 25);
            this.AddUnitToColony.TabIndex = 21;
            this.AddUnitToColony.Text = "Add Unit to Colony";
            this.AddUnitToColony.UseVisualStyleBackColor = true;
            // 
            // AddColonyToPlanet
            // 
            this.AddColonyToPlanet.Location = new System.Drawing.Point(12, 645);
            this.AddColonyToPlanet.Name = "AddColonyToPlanet";
            this.AddColonyToPlanet.Size = new System.Drawing.Size(200, 25);
            this.AddColonyToPlanet.TabIndex = 22;
            this.AddColonyToPlanet.Text = "Add Colony to Planet";
            this.AddColonyToPlanet.UseVisualStyleBackColor = true;
            // 
            // PlanetResourses
            // 
            this.PlanetResourses.FormattingEnabled = true;
            this.PlanetResourses.Location = new System.Drawing.Point(12, 178);
            this.PlanetResourses.Name = "PlanetResourses";
            this.PlanetResourses.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.PlanetResourses.Size = new System.Drawing.Size(303, 160);
            this.PlanetResourses.TabIndex = 23;
            // 
            // ColonyResourses
            // 
            this.ColonyResourses.FormattingEnabled = true;
            this.ColonyResourses.Location = new System.Drawing.Point(321, 178);
            this.ColonyResourses.Name = "ColonyResourses";
            this.ColonyResourses.Size = new System.Drawing.Size(303, 160);
            this.ColonyResourses.TabIndex = 24;
            // 
            // BuildingResourses
            // 
            this.BuildingResourses.FormattingEnabled = true;
            this.BuildingResourses.Location = new System.Drawing.Point(630, 178);
            this.BuildingResourses.Name = "BuildingResourses";
            this.BuildingResourses.Size = new System.Drawing.Size(303, 160);
            this.BuildingResourses.TabIndex = 25;
            // 
            // UnitState
            // 
            this.UnitState.FormattingEnabled = true;
            this.UnitState.Location = new System.Drawing.Point(939, 178);
            this.UnitState.Name = "UnitState";
            this.UnitState.Size = new System.Drawing.Size(303, 160);
            this.UnitState.TabIndex = 26;
            // 
            // ChoosenBuilding
            // 
            this.ChoosenBuilding.FormattingEnabled = true;
            this.ChoosenBuilding.Location = new System.Drawing.Point(1042, 676);
            this.ChoosenBuilding.Name = "ChoosenBuilding";
            this.ChoosenBuilding.Size = new System.Drawing.Size(200, 160);
            this.ChoosenBuilding.Sorted = true;
            this.ChoosenBuilding.TabIndex = 30;
            this.ChoosenBuilding.SelectedIndexChanged += new System.EventHandler(this.ChoosenBuilding_SelectedIndexChanged);
            // 
            // MoveUnitsToBuilding
            // 
            this.MoveUnitsToBuilding.Location = new System.Drawing.Point(1042, 645);
            this.MoveUnitsToBuilding.Name = "MoveUnitsToBuilding";
            this.MoveUnitsToBuilding.Size = new System.Drawing.Size(200, 25);
            this.MoveUnitsToBuilding.TabIndex = 29;
            this.MoveUnitsToBuilding.Text = "Move Units to Building";
            this.MoveUnitsToBuilding.UseVisualStyleBackColor = true;
            // 
            // MoveResoursesToBuilding
            // 
            this.MoveResoursesToBuilding.Location = new System.Drawing.Point(1042, 614);
            this.MoveResoursesToBuilding.Name = "MoveResoursesToBuilding";
            this.MoveResoursesToBuilding.Size = new System.Drawing.Size(200, 25);
            this.MoveResoursesToBuilding.TabIndex = 31;
            this.MoveResoursesToBuilding.Text = "Move Resourses to Building";
            this.MoveResoursesToBuilding.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 848);
            this.Controls.Add(this.MoveResoursesToBuilding);
            this.Controls.Add(this.ChoosenBuilding);
            this.Controls.Add(this.MoveUnitsToBuilding);
            this.Controls.Add(this.UnitState);
            this.Controls.Add(this.BuildingResourses);
            this.Controls.Add(this.ColonyResourses);
            this.Controls.Add(this.PlanetResourses);
            this.Controls.Add(this.AddColonyToPlanet);
            this.Controls.Add(this.AddUnitToColony);
            this.Controls.Add(this.StarShipUnits);
            this.Controls.Add(this.StarShipColonies);
            this.Controls.Add(this.AddChoosenStarShip);
            this.Controls.Add(this.AddColonyToStarShip);
            this.Controls.Add(this.AddUnitToStarShip);
            this.Controls.Add(this.AddBuildingToColony);
            this.Controls.Add(this.AddChoosenUnit);
            this.Controls.Add(this.AddChoosenBuilding);
            this.Controls.Add(this.AddChoosenColony);
            this.Controls.Add(this.ChoosenPlanet);
            this.Controls.Add(this.ColonizePlanet);
            this.Controls.Add(this.AddStarShip);
            this.Controls.Add(this.StarShips);
            this.Controls.Add(this.Units);
            this.Controls.Add(this.Buildings);
            this.Controls.Add(this.Colonies);
            this.Controls.Add(this.Planets);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Planets;
        private System.Windows.Forms.ListBox Colonies;
        private System.Windows.Forms.ListBox Buildings;
        private System.Windows.Forms.ListBox Units;
        private System.Windows.Forms.ListBox StarShips;
        private System.Windows.Forms.Button AddStarShip;
        private System.Windows.Forms.Button ColonizePlanet;
        private System.Windows.Forms.ListBox ChoosenPlanet;
        private System.Windows.Forms.ListBox AddChoosenColony;
        private System.Windows.Forms.ListBox AddChoosenBuilding;
        private System.Windows.Forms.ListBox AddChoosenUnit;
        private System.Windows.Forms.Button AddBuildingToColony;
        private System.Windows.Forms.Button AddUnitToStarShip;
        private System.Windows.Forms.Button AddColonyToStarShip;
        private System.Windows.Forms.ListBox AddChoosenStarShip;
        private System.Windows.Forms.ListBox StarShipColonies;
        private System.Windows.Forms.ListBox StarShipUnits;
        private System.Windows.Forms.Button AddUnitToColony;
        private System.Windows.Forms.Button AddColonyToPlanet;
        private System.Windows.Forms.ListBox PlanetResourses;
        private System.Windows.Forms.ListBox ColonyResourses;
        private System.Windows.Forms.ListBox BuildingResourses;
        private System.Windows.Forms.ListBox UnitState;
        private System.Windows.Forms.ListBox ChoosenBuilding;
        private System.Windows.Forms.Button MoveUnitsToBuilding;
        private System.Windows.Forms.Button MoveResoursesToBuilding;
    }
}

