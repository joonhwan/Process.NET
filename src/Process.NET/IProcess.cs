using System;
using Process.NET.Memory;
using Process.NET.Modules;
using Process.NET.Native.Types;
using Process.NET.Threads;
using Process.NET.Windows;

namespace Process.NET
{
    /// <summary>
    ///     A class that offsers several tools to interact with a process.
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public interface IProcess : IDisposable
    {
        /// <summary>
        ///     Provide access to the opened process.
        /// </summary>
        System.Diagnostics.Process Native { get; }

        /// <summary>
        ///     The process handle opened with all rights.
        /// </summary>
        SafeMemoryHandle Handle { get; }

        /// <summary>
        ///     Class for reading and writing memory.
        /// </summary>
        IMemory Memory { get; }

        /// <summary>
        ///     Factory for manipulating threads.
        /// </summary>
        IThreadFactory ThreadFactory { get; }

        /// <summary>
        ///     Factory for manipulating modules and libraries.
        /// </summary>
        IModuleFactory ModuleFactory { get; }

        /// <summary>
        ///     Factory for manipulating memory space.
        /// </summary>
        IMemoryFactory MemoryFactory { get; }

        /// <summary>
        ///     Factory for manipulating windows.
        /// </summary>
        IWindowFactory WindowFactory { get; }

        /// <summary>
        ///     Gets the specified module in the process.
        /// </summary>
        /// <param name="moduleName">The name of module.</param>
        /// <returns><see cref="IProcessModule" />.</returns>
        IProcessModule this[string moduleName] { get; }

        /// <summary>
        ///     Gets a pointer to the specified address in the process.
        /// </summary>
        /// <param name="intPtr">The address pointed.</param>
        /// <returns>
        ///     <see cref="IPointer" />
        /// </returns>
        IPointer this[IntPtr intPtr] { get; }
    }
}