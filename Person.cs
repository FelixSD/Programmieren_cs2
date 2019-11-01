using System;

namespace Programmieren_cs2 {
    class Person {
        public string name;
        public int alter;

        public virtual string GetAnrede() {
            if(this.alter < 18) {
                return "Hey " + name;
            } else {
                return "Sehr geehrte(r) " + name;
            }
        }
    }

    class Frau : Person {
        public override string GetAnrede() {
            return "Sehr geehrte Frau " + name;
        }
    }

    class Mann : Person {
        public override string GetAnrede() {
            return "Sehr geehrter Herr " + name;
        }
    }
}