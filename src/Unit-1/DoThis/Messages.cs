﻿namespace WinTail
{
    public class Messages
    {
        #region System Messages
        public class ContinueProcessing { }
        public class ValidateInput
        {
            public string Input { get; set; }

            public ValidateInput(string input) => Input = input;
        }
        
        #endregion

        #region Success Messages
        public class InputSuccess
        {
            public string Reason { get; set; }
            public InputSuccess(string reason) => Reason = reason;
        }
        #endregion

        #region Error Messages
        public class InputError
        {
            public string Reason { get; set; }
            public InputError(string reason) => Reason = reason;
        }

        public class NullInputError : InputError
        {
            public NullInputError(string reason) : base(reason) { }
        }

        public class ValidationError : InputError
        {
            public ValidationError(string reason) : base(reason) { }
        }
        #endregion
    }
}