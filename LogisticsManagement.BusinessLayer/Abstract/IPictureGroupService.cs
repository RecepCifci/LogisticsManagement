using LogisticsManagement.Core.Results;
using LogisticsManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.BusinessLayer.Abstract
{
    public interface IPictureGroupService
    {
        IDataResult<PictureGroup> GetById(int Id);
        IDataResult<List<PictureGroup>> GetList();
        IResult Add(PictureGroup pictureGroup);
        IResult Update(PictureGroup pictureGroup);
        IResult Delete(PictureGroup pictureGroup);
    }
}
