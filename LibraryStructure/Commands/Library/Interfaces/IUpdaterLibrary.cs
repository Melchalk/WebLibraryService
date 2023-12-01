﻿using ServiceModels.Requests.Library;
using ServiceModels.Responses.Library;
using WebLibrary.Commands.Common_interfaces;

namespace LibraryStructure.Commands.Library.Interfaces;

public interface IUpdaterLibrary : IUpdater<UpdateLibraryRequest, UpdateLibraryResponse>
{
}