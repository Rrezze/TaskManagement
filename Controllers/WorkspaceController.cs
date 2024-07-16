using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using taskManagement.Command;
using taskManagement.Models;
using taskManagement.Query;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace taskManagement.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class WorkspaceController : ControllerBase
    {
        private readonly IMediator mediator;

        public WorkspaceController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Workspace>> GetWorkspaceListAsync()
        {
            var workspace = await mediator.Send(new GetWorkspaceListQuery());

            return workspace;
        }

        [HttpGet("workspaceId")]
        public async Task<Workspace> GetWorkspaceByIdAsync(int workspaceID)
        {
            var workspace = await mediator.Send(new GetWorkspaceByIdQuery() { Id = workspaceID });
            return workspace;

        }

        [HttpPost]

        public async Task<Workspace> AddWorkspaceAsync(Workspace workspace)
        {
            var workspaces = await mediator.Send(new CreateWorkspaceCommand(

                    workspace.WorkspaceName

                )) ;
                return workspace;
        }

        [HttpPut]

        public async Task<int> UpdateWorkspaceAsync(Workspace workspace)
        {
            var isWorkspaceUpdated = await mediator.Send(new UpdateWorkspaceCommand(
                workspace.WorkspaceId,
                workspace.WorkspaceName

                ));
            return isWorkspaceUpdated;
        }

        [HttpDelete]

        public async Task<int> DeleteWorkspaceAsync(int Id)
        {
            return await mediator.Send(new DeleteWorkspaceCommand() { WorkspaceId = Id });
        }
        
    }
}

