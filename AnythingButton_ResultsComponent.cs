using Grasshopper;
using Grasshopper.Kernel;
using Rhino.Geometry;
using System;
using System.Collections.Generic;

namespace AnythingButton_Results
{
    
    public class AnythingButton_ResultsComponent : GH_Component
    {

        public AnythingButton_ResultsComponent()
          : base("AnythingButton_ResultsComponent", "Nickname",
            "Description",
            "Category", "Subcategory")
        {
        }

        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
        }

        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
        }

        protected override System.Drawing.Bitmap Icon => null;

        public override Guid ComponentGuid => new Guid("f5a32c0e-d422-4103-99d0-e18953ee0d25");
    }
}