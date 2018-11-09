using FTN.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTN.Services.NetworkModelService.DataModel.Core
{
    public class Terminal : IdentifiedObject
    {
        private long connectivityNode = 0;
        private long condEq = 0;

        public long ConnectivityNode
        {
            get
            {
                return connectivityNode;
            }

            set
            {
                connectivityNode = value;
            }
        }

        public long CondEq
        {
            get
            {
                return condEq;
            }

            set
            {
                condEq = value;
            }
        }

        public Terminal(long globalId) : base(globalId) 
		{
        }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                Terminal x = (Terminal)obj;
                return ((x.connectivityNode == this.connectivityNode) && (x.condEq == this.condEq));
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

        public override bool HasProperty(ModelCode property)
        {
            switch (property)
            {
                case ModelCode.TERMINAL_CONDEQ:
                case ModelCode.TERMINAL_CONNODE:
                    return true;
                default:
                    return base.HasProperty(property);
            }
        }

        public override void GetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.TERMINAL_CONDEQ:
                    property.SetValue(condEq);
                    break;
                case ModelCode.TERMINAL_CONNODE:
                    property.SetValue(connectivityNode);
                    break;

                default:
                    base.GetProperty(property);
                    break;
            }
        }

        public override void SetProperty(Property property)
        {
            switch (property.Id)
            {
                case ModelCode.TERMINAL_CONDEQ:
                    condEq = property.AsReference();
                    break;

                case ModelCode.TERMINAL_CONNODE:
                    connectivityNode = property.AsReference();
                    break;

                default:
                    base.SetProperty(property);
                    break;
            }
        }

        #endregion IAccess implementation

        #region IReference implementation	

        public override void GetReferences(Dictionary<ModelCode, List<long>> references, TypeOfReference refType)
        {
            if (connectivityNode != 0 && (refType != TypeOfReference.Reference || refType != TypeOfReference.Both))
            {
                references[ModelCode.TERMINAL_CONNODE] = new List<long>();
                references[ModelCode.TERMINAL_CONNODE].Add(connectivityNode);
            }

            if (condEq != 0 && (refType != TypeOfReference.Reference || refType != TypeOfReference.Both))
            {
                references[ModelCode.TERMINAL_CONDEQ] = new List<long>();
                references[ModelCode.TERMINAL_CONDEQ].Add(condEq);
            }

            base.GetReferences(references, refType);
        }

        #endregion IReference implementation
    }
}
