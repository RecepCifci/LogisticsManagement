using LogisticsManagement.BusinessLayer.Abstract;
using LogisticsManagement.BusinessLayer.Constants;
using LogisticsManagement.Core.Results;
using LogisticsManagement.DataAccessLayer.Abstract;
using LogisticsManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogisticsManagement.BusinessLayer.Concrete
{
    class PictureGroupManager : IPictureGroupService
    {
        private IPictureGroupDal _pictureGroupDal;
        public PictureGroupManager(IPictureGroupDal pictureGroupDal)
        {
            _pictureGroupDal = pictureGroupDal;
        }

        public IResult Add(PictureGroup pictureGroup)
        {
            _pictureGroupDal.Add(pictureGroup);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(PictureGroup pictureGroup)
        {
            _pictureGroupDal.Delete(pictureGroup);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<PictureGroup> GetById(int pictureGroupId)
        {
            return new SuccessDataResult<PictureGroup>(_pictureGroupDal.Get(c => c.ID == pictureGroupId));
        }

        public IDataResult<List<PictureGroup>> GetList()
        {
            return new SuccessDataResult<List<PictureGroup>>(_pictureGroupDal.GetList().OrderBy(c => c.ID).ToList());
        }

        public IResult Update(PictureGroup pictureGroup)
        {
            _pictureGroupDal.Update(pictureGroup);
            return new SuccessResult(Messages.Updated);
        }
    }
}
