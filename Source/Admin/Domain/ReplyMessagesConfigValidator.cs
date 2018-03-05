/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2017-2018 The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using FluentValidation;

namespace Domain
{
    public class ReplyMessagesConfigValidator : AbstractValidator<UpdateReplyMessagesConfig>
    {
        public ReplyMessagesConfigValidator(IReplyMessagesConfigRules rules)
        {
            RuleFor(v => v.Messages).NotNull().WithMessage("Messages is missing");
            RuleFor(v => v.Messages.Keys).Must(rules.IsTagsValid).WithMessage("Tags are not valid");
        }
    }
}