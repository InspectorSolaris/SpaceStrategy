using SpaceStrategy.Class.Regular;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceStrategy.Class.Abstract
{
    abstract class Buildable
    {
        protected Buildable
            (
            State buildingState, TimeSpan timeToBuildSec, TimeSpan timeToDestroySec, List<ResourseBunch> resoursesForBuildingNeeded, Storage storageForBuilding
            )
        {
            this.BuildingState = buildingState;
            this.TimeToBuildSec = timeToBuildSec;
            this.TimeToDestroySec = timeToDestroySec;
            this.ResoursesForBuildingNeeded = resoursesForBuildingNeeded;
            this.StorageForBuilding = storageForBuilding;
        }

        public enum State
        {
            Building,
            Builded,
            Destroying,
            Destroyed
        }

        public State BuildingState { get; }

        private TimeSpan TimeToBuildSec { get; }

        private TimeSpan TimeToDestroySec { get; }

        public List<ResourseBunch> ResoursesForBuildingNeeded { get; }

        private Storage StorageForBuilding { get; }

        public bool AddResourseForBuild(ResourseBunch resourseBunch)
        {
            return BuildingState == State.Destroyed && StorageForBuilding.Add(resourseBunch);
        }
        
        public bool AddResourseForBuild(List<ResourseBunch> resourseBunches)
        {
            return BuildingState == State.Destroyed && StorageForBuilding.Add(resourseBunches);
        }

        public async Task<bool> Build()
        {
            if(IsEnoughResourses() && BuildingState == State.Destroyed)
            {
                await Task.Delay(TimeToBuildSec);

                StorageForBuilding.Remove(StorageForBuilding.ResourseBunches);

                return true;
            }

            return false;
        }

        public async Task<bool> Destory()
        {
            if(BuildingState == State.Builded)
            {
                await Task.Delay(TimeToDestroySec);

                return true;
            }

            return false;
        }

        private bool IsEnoughResourses()
        {
            bool isEnough = true;

            ResoursesForBuildingNeeded.ForEach(r => isEnough = isEnough && StorageForBuilding.FindByResourseId(r.Resourse.Id).Amount - r.Amount >= 0);

            return isEnough;
        }
    }
}
