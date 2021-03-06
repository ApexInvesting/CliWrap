﻿using System.Collections.Generic;

namespace CliWrap.Models
{
    /// <summary>
    /// Input used for executing a process.
    /// </summary>
    public partial class ExecutionInput
    {
        /// <summary>
        /// Command line arguments.
        /// </summary>
        public string Arguments { get; }

        /// <summary>
        /// Standard input data.
        /// </summary>
        public string StandardInput { get; }

        /// <summary>
        /// Environment variables.
        /// </summary>
        public IDictionary<string, string> EnvironmentVariables { get; }

        /// <summary />
        public ExecutionInput(string arguments = null, string standardInput = null)
        {
            Arguments = arguments;
            StandardInput = standardInput;
            EnvironmentVariables = new Dictionary<string, string>();
        }
    }

    public partial class ExecutionInput
    {
        /// <summary>
        /// Empty input.
        /// </summary>
        public static ExecutionInput Empty { get; } = new ExecutionInput();
    }
}