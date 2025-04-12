using Grasshopper;
using Grasshopper.Kernel;
using Rhino.Geometry;
using System;
using System.Collections.Generic;

namespace AnythingButton_Results
{
    
}    public class CreateCircleComponent : GH_Component
    {
        public CreateCircleComponent()
          : base("Create Circle", "Circle",
              "Creates a circle given a center point and radius",
              "Category", "Subcategory")
        {
        }

        protected override void RegisterInputParams(GH_InputParamManager pManager)
        {
            pManager.AddPointParameter("Center", "C", "Center point of the circle", GH_ParamAccess.item);
            pManager.AddNumberParameter("Radius", "R", "Radius of the circle", GH_ParamAccess.item);
        }

        protected override void RegisterOutputParams(GH_OutputParamManager pManager)
        {
            pManager.AddCircleParameter("Circle", "C", "Resulting circle", GH_ParamAccess.item);
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
            Point3d center = Point3d.Unset;
            double radius = 0.0;

            if (!DA.GetData(0, ref center)) return;
            if (!DA.GetData(1, ref radius)) return;

            Circle circle = new Circle(center, radius);
            DA.SetData(0, circle);
        }

        public override Guid ComponentGuid
        {
            get { return new Guid("d3b3c5e1-5c3b-4f8b-9f3b-2f3b5e1c3b5e"); }
        }
    }
