﻿using System.Threading.Tasks;
#if NET8_0_OR_GREATER
using Microsoft.JSInterop;
#else
using Microsoft.JSInterop;
#endif

namespace Babylon.Blazor;

public abstract class InstanceCreatorBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InstanceCreator"/> class.
    /// </summary>
    /// <param name="jSInstance">The j s instance.</param>
    protected InstanceCreatorBase(IJSRuntime jSInstance)
    {
        JSInstance = jSInstance;
    }

    /// <summary>
    /// create babylon as an asynchronous operation.
    /// </summary>
    /// <returns>System.Threading.Tasks.Task&lt;Babylon.Blazor.BabylonInstance&gt;.</returns>
    public abstract Task<BabylonInstance> CreateBabylonAsync();

    /// <summary>
    /// The java script instance
    /// </summary>
    protected IJSRuntime JSInstance { get; }
}
