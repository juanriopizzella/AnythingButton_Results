using System.Linq;
using Grasshopper.Kernel;
using Rhino.Geometry;
using System;
using System.Collections.Generic;
using Grasshopper.Kernel.Types;

namespace AnythingButton_Results
{
    public class StackBoxesComponent : GH_Component
    {
        public StackBoxesComponent()
          : base("Stack Boxes", "StackBoxes",
              "Stacks boxes on top of each other",
              "AnythingButton", "AnythingButton")
        {
        }

        protected override void RegisterInputParams(GH_InputParamManager pManager)
        {
            pManager.AddNumberParameter("Width", "W", "Width of the box", GH_ParamAccess.item);
            pManager.AddNumberParameter("Depth", "D", "Depth of the box", GH_ParamAccess.item);
            pManager.AddNumberParameter("Height", "H", "Height of the box", GH_ParamAccess.item);
            pManager.AddIntegerParameter("Count", "C", "Number of boxes", GH_ParamAccess.item);
        }

        protected override void RegisterOutputParams(GH_OutputParamManager pManager)
        {
            pManager.AddBoxParameter("Boxes", "B", "Stacked boxes", GH_ParamAccess.list);
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
            double width = 0;
            double depth = 0;
            double height = 0;
            int count = 0;

            if (!DA.GetData(0, ref width)) return;
            if (!DA.GetData(1, ref depth)) return;
            if (!DA.GetData(2, ref height)) return;
            if (!DA.GetData(3, ref count)) return;

            List<Box> boxes = new List<Box>();
            for (int i = 0; i < count; i++)
            {
                Point3d basePoint = new Point3d(0, 0, i * height);
                Interval xInterval = new Interval(0, width);
                Interval yInterval = new Interval(0, depth);
                Interval zInterval = new Interval(0, height);
                Box box = new Box(new Plane(basePoint, Vector3d.ZAxis), xInterval, yInterval, zInterval);
                boxes.Add(box);
            }

            DA.SetDataList(0, boxes);
        }

        public override Guid ComponentGuid
        {
            get { return new Guid("d3b3c5b4-3c3b-4f3b-8b3b-3b3b3b3b3b3b"); }
        }
    }
}

