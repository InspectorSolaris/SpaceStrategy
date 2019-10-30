using SpaceStrategy.Class.Regular;
using SpaceStrategy.Class.Regular.Implementation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Abstract
{
    abstract partial class Buildable
    {
        protected Buildable
            (
            string name, State buildingState, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> necessaryResourses
            )
        {
            this.Name = name;
            this.BuildingState = buildingState;
            this.TimeToBuildSec = timeToBuildSec;
            this.TimeToDestroySec = timeToDestroySec;
            this.NecessaryResourses = necessaryResourses;
        }

        public enum State
        {
            Building,
            Builded,
            Destroying,
            Destroyed
        }

        public string Name { get; }

        public State BuildingState { get; private set; }

        private TimeSpan TimeToBuildSec { get; }

        private TimeSpan TimeToDestroySec { get; }

        public List<ResourseBunch> NecessaryResourses { get; }

        public async Task<bool> Build(ResourseHolder resourseSource)
        {
            if(IsEnoughResourses(resourseSource) && BuildingState == State.Destroyed)
            {
                BuildingState = State.Building;

                await Task.Delay(TimeToBuildSec);

                BuildingState = State.Builded;

                return true;
            }

            return false;
        }

        public async Task<bool> Destory()
        {
            if(BuildingState == State.Builded)
            {
                BuildingState = State.Destroying;

                await Task.Delay(TimeToDestroySec);

                BuildingState = State.Destroyed;

                return true;
            }

            return false;
        }

        private bool IsEnoughResourses(ResourseHolder resourseSource)
        {
            bool isEnough = true;

            NecessaryResourses.ForEach(r => isEnough = isEnough && resourseSource.FindByResourseId(r.Resourse.Id).Amount - r.Amount >= 0);

            return isEnough;
        }
    }
}
