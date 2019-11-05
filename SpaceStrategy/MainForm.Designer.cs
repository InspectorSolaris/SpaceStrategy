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
            this.MainGameLoop = new System.ComponentModel.BackgroundWorker();
            this.UIUpdater = new System.ComponentModel.BackgroundWorker();
            this.Planets = new System.Windows.Forms.ListBox();
            this.Colonies = new System.Windows.Forms.ListBox();
            this.Buildings = new System.Windows.Forms.ListBox();
            this.Units = new System.Windows.Forms.ListBox();
            this.StarShips = new System.Windows.Forms.ListBox();
            this.StarShipColonies = new System.Windows.Forms.ListBox();
            this.StarShipUnits = new System.Windows.Forms.ListBox();
            this.StarShipColonyBuildings = new System.Windows.Forms.ListBox();
            this.StarShipColonyBuildingUnits = new System.Windows.Forms.ListBox();
            this.PlanetResourses = new System.Windows.Forms.ListBox();
            this.ColonyResourses = new System.Windows.Forms.ListBox();
            this.StarShipColonyResourses = new System.Windows.Forms.ListBox();
            this.AddBuilding = new System.Windows.Forms.ListBox();
            this.AddUnit = new System.Windows.Forms.ListBox();
            this.AddSelectedBuilding = new System.Windows.Forms.Button();
            this.AddSelectedUnit = new System.Windows.Forms.Button();
            this.BuildBuilding = new System.Windows.Forms.Button();
            this.BuildUnit = new System.Windows.Forms.Button();
            this.DestroyBuilding = new System.Windows.Forms.Button();
            this.DestroyUnit = new System.Windows.Forms.Button();
            this.AddColony = new System.Windows.Forms.ListBox();
            this.AddSelectedColony = new System.Windows.Forms.Button();
            this.AddStarShip = new System.Windows.Forms.ListBox();
            this.AddSelectedStarShip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainGameLoop
            // 
            this.MainGameLoop.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MainGameLoop_DoWork);
            // 
            // UIUpdater
            // 
            this.UIUpdater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.UIUpdater_DoWork);
            // 
            // Planets
            // 
            this.Planets.FormattingEnabled = true;
            this.Planets.Location = new System.Drawing.Point(12, 12);
            this.Planets.Name = "Planets";
            this.Planets.Size = new System.Drawing.Size(150, 95);
            this.Planets.TabIndex = 0;
            // 
            // Colonies
            // 
            this.Colonies.FormattingEnabled = true;
            this.Colonies.Location = new System.Drawing.Point(168, 12);
            this.Colonies.Name = "Colonies";
            this.Colonies.Size = new System.Drawing.Size(150, 95);
            this.Colonies.TabIndex = 1;
            // 
            // Buildings
            // 
            this.Buildings.FormattingEnabled = true;
            this.Buildings.Location = new System.Drawing.Point(324, 12);
            this.Buildings.Name = "Buildings";
            this.Buildings.Size = new System.Drawing.Size(150, 95);
            this.Buildings.TabIndex = 2;
            this.Buildings.DoubleClick += new System.EventHandler(this.Buildings_DoubleClick);
            // 
            // Units
            // 
            this.Units.FormattingEnabled = true;
            this.Units.Location = new System.Drawing.Point(480, 12);
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(150, 95);
            this.Units.TabIndex = 3;
            // 
            // StarShips
            // 
            this.StarShips.FormattingEnabled = true;
            this.StarShips.Location = new System.Drawing.Point(324, 173);
            this.StarShips.Name = "StarShips";
            this.StarShips.Size = new System.Drawing.Size(150, 95);
            this.StarShips.TabIndex = 4;
            // 
            // StarShipColonies
            // 
            this.StarShipColonies.FormattingEnabled = true;
            this.StarShipColonies.Location = new System.Drawing.Point(480, 173);
            this.StarShipColonies.Name = "StarShipColonies";
            this.StarShipColonies.Size = new System.Drawing.Size(150, 95);
            this.StarShipColonies.TabIndex = 5;
            // 
            // StarShipUnits
            // 
            this.StarShipUnits.FormattingEnabled = true;
            this.StarShipUnits.Location = new System.Drawing.Point(480, 274);
            this.StarShipUnits.Name = "StarShipUnits";
            this.StarShipUnits.Size = new System.Drawing.Size(150, 95);
            this.StarShipUnits.TabIndex = 6;
            // 
            // StarShipColonyBuildings
            // 
            this.StarShipColonyBuildings.FormattingEnabled = true;
            this.StarShipColonyBuildings.Location = new System.Drawing.Point(636, 173);
            this.StarShipColonyBuildings.Name = "StarShipColonyBuildings";
            this.StarShipColonyBuildings.Size = new System.Drawing.Size(150, 95);
            this.StarShipColonyBuildings.TabIndex = 7;
            // 
            // StarShipColonyBuildingUnits
            // 
            this.StarShipColonyBuildingUnits.FormattingEnabled = true;
            this.StarShipColonyBuildingUnits.Location = new System.Drawing.Point(792, 173);
            this.StarShipColonyBuildingUnits.Name = "StarShipColonyBuildingUnits";
            this.StarShipColonyBuildingUnits.Size = new System.Drawing.Size(150, 95);
            this.StarShipColonyBuildingUnits.TabIndex = 8;
            // 
            // PlanetResourses
            // 
            this.PlanetResourses.FormattingEnabled = true;
            this.PlanetResourses.Location = new System.Drawing.Point(12, 274);
            this.PlanetResourses.Name = "PlanetResourses";
            this.PlanetResourses.Size = new System.Drawing.Size(150, 95);
            this.PlanetResourses.TabIndex = 9;
            // 
            // ColonyResourses
            // 
            this.ColonyResourses.FormattingEnabled = true;
            this.ColonyResourses.Location = new System.Drawing.Point(168, 274);
            this.ColonyResourses.Name = "ColonyResourses";
            this.ColonyResourses.Size = new System.Drawing.Size(150, 95);
            this.ColonyResourses.TabIndex = 10;
            // 
            // StarShipColonyResourses
            // 
            this.StarShipColonyResourses.FormattingEnabled = true;
            this.StarShipColonyResourses.Location = new System.Drawing.Point(324, 274);
            this.StarShipColonyResourses.Name = "StarShipColonyResourses";
            this.StarShipColonyResourses.Size = new System.Drawing.Size(150, 95);
            this.StarShipColonyResourses.TabIndex = 11;
            // 
            // AddBuilding
            // 
            this.AddBuilding.FormattingEnabled = true;
            this.AddBuilding.Location = new System.Drawing.Point(324, 476);
            this.AddBuilding.Name = "AddBuilding";
            this.AddBuilding.Size = new System.Drawing.Size(150, 95);
            this.AddBuilding.TabIndex = 12;
            // 
            // AddUnit
            // 
            this.AddUnit.FormattingEnabled = true;
            this.AddUnit.Location = new System.Drawing.Point(480, 476);
            this.AddUnit.Name = "AddUnit";
            this.AddUnit.Size = new System.Drawing.Size(150, 95);
            this.AddUnit.TabIndex = 13;
            // 
            // AddSelectedBuilding
            // 
            this.AddSelectedBuilding.Location = new System.Drawing.Point(324, 447);
            this.AddSelectedBuilding.Name = "AddSelectedBuilding";
            this.AddSelectedBuilding.Size = new System.Drawing.Size(150, 23);
            this.AddSelectedBuilding.TabIndex = 14;
            this.AddSelectedBuilding.Text = "Add Selected Building";
            this.AddSelectedBuilding.UseVisualStyleBackColor = true;
            this.AddSelectedBuilding.Click += new System.EventHandler(this.AddSelectedBuilding_Click);
            // 
            // AddSelectedUnit
            // 
            this.AddSelectedUnit.Location = new System.Drawing.Point(481, 447);
            this.AddSelectedUnit.Name = "AddSelectedUnit";
            this.AddSelectedUnit.Size = new System.Drawing.Size(149, 23);
            this.AddSelectedUnit.TabIndex = 15;
            this.AddSelectedUnit.Text = "Add Selected Unit";
            this.AddSelectedUnit.UseVisualStyleBackColor = true;
            this.AddSelectedUnit.Click += new System.EventHandler(this.AddSelectedUnit_Click);
            // 
            // BuildBuilding
            // 
            this.BuildBuilding.Location = new System.Drawing.Point(324, 114);
            this.BuildBuilding.Name = "BuildBuilding";
            this.BuildBuilding.Size = new System.Drawing.Size(150, 23);
            this.BuildBuilding.TabIndex = 16;
            this.BuildBuilding.Text = "Build Building";
            this.BuildBuilding.UseVisualStyleBackColor = true;
            this.BuildBuilding.Click += new System.EventHandler(this.BuildBuilding_Click);
            // 
            // BuildUnit
            // 
            this.BuildUnit.Location = new System.Drawing.Point(480, 114);
            this.BuildUnit.Name = "BuildUnit";
            this.BuildUnit.Size = new System.Drawing.Size(150, 23);
            this.BuildUnit.TabIndex = 17;
            this.BuildUnit.Text = "Build Unit";
            this.BuildUnit.UseVisualStyleBackColor = true;
            this.BuildUnit.Click += new System.EventHandler(this.BuildUnit_Click);
            // 
            // DestroyBuilding
            // 
            this.DestroyBuilding.Location = new System.Drawing.Point(324, 144);
            this.DestroyBuilding.Name = "DestroyBuilding";
            this.DestroyBuilding.Size = new System.Drawing.Size(150, 23);
            this.DestroyBuilding.TabIndex = 18;
            this.DestroyBuilding.Text = "Destroy Building";
            this.DestroyBuilding.UseVisualStyleBackColor = true;
            this.DestroyBuilding.Click += new System.EventHandler(this.DestroyBuilding_Click);
            // 
            // DestroyUnit
            // 
            this.DestroyUnit.Location = new System.Drawing.Point(480, 144);
            this.DestroyUnit.Name = "DestroyUnit";
            this.DestroyUnit.Size = new System.Drawing.Size(150, 23);
            this.DestroyUnit.TabIndex = 19;
            this.DestroyUnit.Text = "Destroy Unit";
            this.DestroyUnit.UseVisualStyleBackColor = true;
            this.DestroyUnit.Click += new System.EventHandler(this.DestroyUnit_Click);
            // 
            // AddColony
            // 
            this.AddColony.FormattingEnabled = true;
            this.AddColony.Location = new System.Drawing.Point(168, 476);
            this.AddColony.Name = "AddColony";
            this.AddColony.Size = new System.Drawing.Size(150, 95);
            this.AddColony.TabIndex = 20;
            // 
            // AddSelectedColony
            // 
            this.AddSelectedColony.Location = new System.Drawing.Point(168, 447);
            this.AddSelectedColony.Name = "AddSelectedColony";
            this.AddSelectedColony.Size = new System.Drawing.Size(150, 23);
            this.AddSelectedColony.TabIndex = 21;
            this.AddSelectedColony.Text = "Add Selected Colony";
            this.AddSelectedColony.UseVisualStyleBackColor = true;
            this.AddSelectedColony.Click += new System.EventHandler(this.AddSelectedColony_Click);
            // 
            // AddStarShip
            // 
            this.AddStarShip.FormattingEnabled = true;
            this.AddStarShip.Location = new System.Drawing.Point(12, 476);
            this.AddStarShip.Name = "AddStarShip";
            this.AddStarShip.Size = new System.Drawing.Size(150, 95);
            this.AddStarShip.TabIndex = 22;
            // 
            // AddSelectedStarShip
            // 
            this.AddSelectedStarShip.Location = new System.Drawing.Point(12, 447);
            this.AddSelectedStarShip.Name = "AddSelectedStarShip";
            this.AddSelectedStarShip.Size = new System.Drawing.Size(150, 23);
            this.AddSelectedStarShip.TabIndex = 23;
            this.AddSelectedStarShip.Text = "Add Selected StarShip";
            this.AddSelectedStarShip.UseVisualStyleBackColor = true;
            this.AddSelectedStarShip.Click += new System.EventHandler(this.AddSelectedStarShip_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 583);
            this.Controls.Add(this.AddSelectedStarShip);
            this.Controls.Add(this.AddStarShip);
            this.Controls.Add(this.AddSelectedColony);
            this.Controls.Add(this.AddColony);
            this.Controls.Add(this.DestroyUnit);
            this.Controls.Add(this.DestroyBuilding);
            this.Controls.Add(this.BuildUnit);
            this.Controls.Add(this.BuildBuilding);
            this.Controls.Add(this.AddSelectedUnit);
            this.Controls.Add(this.AddSelectedBuilding);
            this.Controls.Add(this.AddUnit);
            this.Controls.Add(this.AddBuilding);
            this.Controls.Add(this.StarShipColonyResourses);
            this.Controls.Add(this.ColonyResourses);
            this.Controls.Add(this.PlanetResourses);
            this.Controls.Add(this.StarShipColonyBuildingUnits);
            this.Controls.Add(this.StarShipColonyBuildings);
            this.Controls.Add(this.StarShipUnits);
            this.Controls.Add(this.StarShipColonies);
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
        private System.ComponentModel.BackgroundWorker MainGameLoop;
        private System.ComponentModel.BackgroundWorker UIUpdater;
        private System.Windows.Forms.ListBox Planets;
        private System.Windows.Forms.ListBox Colonies;
        private System.Windows.Forms.ListBox Buildings;
        private System.Windows.Forms.ListBox Units;
        private System.Windows.Forms.ListBox StarShips;
        private System.Windows.Forms.ListBox StarShipColonies;
        private System.Windows.Forms.ListBox StarShipUnits;
        private System.Windows.Forms.ListBox StarShipColonyBuildings;
        private System.Windows.Forms.ListBox StarShipColonyBuildingUnits;
        private System.Windows.Forms.ListBox PlanetResourses;
        private System.Windows.Forms.ListBox ColonyResourses;
        private System.Windows.Forms.ListBox StarShipColonyResourses;
        private System.Windows.Forms.ListBox AddBuilding;
        private System.Windows.Forms.ListBox AddUnit;
        private System.Windows.Forms.Button AddSelectedBuilding;
        private System.Windows.Forms.Button AddSelectedUnit;
        private System.Windows.Forms.Button BuildBuilding;
        private System.Windows.Forms.Button BuildUnit;
        private System.Windows.Forms.Button DestroyBuilding;
        private System.Windows.Forms.Button DestroyUnit;
        private System.Windows.Forms.ListBox AddColony;
        private System.Windows.Forms.Button AddSelectedColony;
        private System.Windows.Forms.ListBox AddStarShip;
        private System.Windows.Forms.Button AddSelectedStarShip;
    }
}

