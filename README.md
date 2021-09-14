# Macro King

A macro tool for multiple keyboards

## Use Cases

This is designed to be a poor mans StreamDeck. Plug in any extra keyboard and use it for hotkeys! It ~~has~~ will have integration for YouTube and Twitch livestreams, but you'll be able to use it as a regular hotkey or macro tool.

## Inspiration

This tool is inspired by [Taran van Hemert](https://twitter.com/TaranVH), one of the primary video editors for Linus Tech Tips. They use **so many** keyboards for editing videos, it's kind of mad. But yeah, this is a tool for multi-keyboard users.

## How it works

As you might know, Windows doesn't really play well with multiple keyboards. Sure, you can plug in multiple keyboards, and pressing keys on either one will work, but Windows won't differentiate between them. Pressing NUMPAD1 on keyboard one will give the same result as pressing NUMPAD1 on keyboard two.

But there is a way around this! Windows provides a [RawInput API](https://docs.microsoft.com/en-us/windows/win32/inputdev/raw-input) which enables developers to check, which HID an input came from.

MacroKing uses a C# Wrapper around this api called [RawInput.Sharp](https://github.com/mfakane/rawinput-sharp), which abstracts the low level stuff for me.
