﻿using Microsoft.AspNetCore.Components.Forms;

namespace PersonManagerUI.Shared.CustomControls
{
    public class InputSelectNumber<T> : InputSelect<T>
    {
        protected override bool TryParseValueFromString(
            string value, out T result, out string validationErrorMessage)
        {
            if (typeof(T) != typeof(int?) && typeof(T) != typeof(int))
                return base.TryParseValueFromString(value, out result, out validationErrorMessage);

            if (int.TryParse(value, out var resultInt))
            {
                result = (T)(object)resultInt;
                validationErrorMessage = null;
                return true;
            }

            result = default;
            validationErrorMessage = "The chosen value is not a valid number";
            return false;
        }
    }
}
