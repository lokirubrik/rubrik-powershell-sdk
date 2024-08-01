### ChatMessage
- messageContent: System.String
  - The content of the message.
- timestamp: DateTime
  - The time at which the message was sent.
- speaker: ChatSpeaker
  - The speaker of the message.
- nestedMessage: NestedChatMessage
  - The nested message of the chat
- suggestions: list of System.Strings
  - Message suggestions.
- citations: list of Citations
  - Citations. Deprecated. Use references instead.
- messageId: System.String
  - The ID of the chat message.
- references: list of LlmReferences
  - List of reference documents.