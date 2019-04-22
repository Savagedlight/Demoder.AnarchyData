/*
 * Demoder.AnarchyData
 *
 * Copyright (c) 2012-2016 Marie Helene Kvello-Aune 
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either 
 * version 3 of the License.
 * 
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public 
 * License along with this library.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demoder.AnarchyData
{
    public static class InterpolationRegistry
    {
        public static Dictionary<Operator, OperatorInterpolation> Operators { get; private set; }
        public static Dictionary<Stat, bool> Stats { get; private set; }

        static InterpolationRegistry()
        {
            Operators = new Dictionary<Operator, OperatorInterpolation>();
            Stats = new Dictionary<Stat, bool>();
            InitializeOperators();
            InitializeStats();
        }

        #region Public methods
        public static void Register(OperatorInterpolation interpolation)
        {
            Operators[interpolation.Operator] = interpolation;
        }

        public static void Register(bool interpolateValue1, bool interpolateValue2, params Operator[] operators)
        {
            foreach (Operator op in operators)
            {
                Register(new OperatorInterpolation(op, interpolateValue1, interpolateValue2));
            }
        }

        public static void Register(Stat stat, bool interpolate)
        {
            Stats[stat] = interpolate;
        }

        public static bool Interpolate(Stat stat)
        {
            if (!Stats.ContainsKey(stat)) { return false; }
            return Stats[stat];
        }

        public static bool InterpolateOperatorValue1(Operator op)
        {
            if (!Operators.ContainsKey(op)) { return false; }
            return Operators[op].InterpolateValue1;
        }

        public static bool InterpolateOperatorValue2(Operator op)
        {
            if (!Operators.ContainsKey(op)) { return false; }
            return Operators[op].InterpolateValue2;
        }
        #endregion

        private static void InitializeOperators()
        {
            Register(false, true,
                //Operator.StatBitNotSet,
                //Operator.StatBitSet,
                Operator.StatEqual,
                Operator.StatGreaterThan,
                Operator.StatLessThan,
                Operator.StatNotEqual
                );

            // Perk stuff
            Register(false, true,
                Operator.PerkTrained,
                Operator.PerkNotTrained,
                Operator.PerkLocked, // Unsure about this one
                Operator.PerkNotLocked // Unsure about this one
                );

            // Unsure about this one
            Register(false, true,
                Operator.NeedFreeInventorySlots
                );
        }

        private static void InitializeStats()
        {
            Register(Stat.AttackDelay, true);
            Register(Stat.AttackDelayCap, true);
            Register(Stat.AttackRange, true);
            Register(Stat.AttackSpeed, true);
            Register(Stat.BurstRecharge, true);
            Register(Stat.CooldownTime1, true);
            Register(Stat.CooldownTime2, true);
            Register(Stat.CooldownTime3, true);
            Register(Stat.CooldownTime4, true);
            Register(Stat.CriticalBonus, true);
            Register(Stat.EquipDelay, true);
            Register(Stat.FullAutoRecharge, true);
            Register(Stat.Mass, true);
            Register(Stat.MartialArts, true);
            Register(Stat.MinDamage, true);
            Register(Stat.MaxDamage, true);
            Register(Stat.MaxMass, true);
            // Unsure about this one
            Register(Stat.MaxEnergy, true);
            Register(Stat.MaxBeneficialSkill, true);
            Register(Stat.MultiMelee, true);
            Register(Stat.MultiRanged, true);
            Register(Stat.RechargeDelay, true);

            Register(Stat.Value, true);
            Register(Stat.WeaponRange, true);
            
        }
    }


    public class OperatorInterpolation
    {
        public OperatorInterpolation() { }
        public OperatorInterpolation(Operator op, bool interpolateValue1, bool interpolateValue2) 
        {
            this.Operator = op;
            this.InterpolateValue1 = interpolateValue1;
            this.InterpolateValue2 = interpolateValue2;
        }
        public Operator Operator { get; set; }
        public bool InterpolateValue1 { get; set; }
        public bool InterpolateValue2 { get; set; }

        #region Overrides
        public override bool Equals(object obj)
        {
            if (!(obj is OperatorInterpolation))
            {
                return base.Equals(obj);
            }
            OperatorInterpolation other = (OperatorInterpolation)obj;
            if (other.Operator != this.Operator) { return false; }
            if (other.InterpolateValue1 != this.InterpolateValue1) { return false; }
            if (other.InterpolateValue2 != this.InterpolateValue2) { return false; }
            return true;
        }

        public override int GetHashCode()
        {
            return this.Operator.GetHashCode();
        }
        #endregion
    }
}
