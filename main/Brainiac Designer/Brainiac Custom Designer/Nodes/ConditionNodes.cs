//using System;
using System.Collections.Generic;
using System.Text;
using Brainiac.Design.Nodes;
using Brainiac.Design.Attributes;

namespace BrainiacCustomDesigner.Nodes
{
	public class Probability : Condition
	{
        protected int percent = 0;
        [DesignerInteger("概率", "百分比", "Basic", DesignerProperty.DisplayMode.Parameter, 0, DesignerProperty.DesignerFlags.NoFlags, "Percent", 0, 100, 1, "%")]
        public int Percent
        {
            get { return percent; }
            set { percent = value; }
        }

        public Probability()
            : base("概率节点", "随机概率执行子节点")
		{
		}
	}
}
