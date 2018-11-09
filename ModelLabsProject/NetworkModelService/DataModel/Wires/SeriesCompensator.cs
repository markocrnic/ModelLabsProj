using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTN.Services.NetworkModelService.DataModel.Wires
{
    public class SeriesCompensator : ConductingEquipment
    {
        private float r;
        private float r0;
        private float x;
        private float x0;

        public SeriesCompensator(long globalId)
			: base(globalId)
		{
        }

        public float R
        {
            get
            {
                return r;
            }

            set
            {
                r = value;
            }
        }

        public float R0
        {
            get
            {
                return r0;
            }

            set
            {
                r0 = value;
            }
        }

        public float X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public float X0
        {
            get
            {
                return x0;
            }

            set
            {
                x0 = value;
            }
        }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                SeriesCompensator x = (SeriesCompensator)obj;
                return (x.R == this.R && x.R0 == this.R0 && x.X == this.X && x.X0 == this.X0);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #region IAccess implementation

        public override bool HasProperty(ModelCode t)
        {
            switch (t)
            {
                case ModelCode.SERIESCOMP_R:
                case ModelCode.SERIESCOMP_R0:
                case ModelCode.SERIESCOMP_X:
                case ModelCode.SERIESCOMP_X0:
                    return true;

                default:
                    return base.HasProperty(t);
            }
        }

        public override void GetProperty(Property prop)
        {
            switch (prop.Id)
            {

                case ModelCode.SERIESCOMP_R:
                    prop.SetValue(r);
                    break;

                case ModelCode.SERIESCOMP_R0:
                    prop.SetValue(r0);
                    break;

                case ModelCode.SERIESCOMP_X:
                    prop.SetValue(x);
                    break;
                case ModelCode.SERIESCOMP_X0:
                    prop.SetValue(x0);
                    break;

                default:
                    base.GetProperty(prop);
                    break;
            }
        }

        public override void SetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.SERIESCOMP_R:
                    r = property.AsFloat();
                    break;

                case ModelCode.SERIESCOMP_R0:
                    r0 = property.AsFloat();
                    break;

                case ModelCode.SERIESCOMP_X:
                    x = property.AsFloat();
                    break;

                case ModelCode.SERIESCOMP_X0:
                    x0 = property.AsFloat();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }

        #endregion IAccess implementation
    }
}
