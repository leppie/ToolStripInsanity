# ToolStripInsanity

WTF is the use of this thing? 

How did it ever pass QA?

FOR 10 FUCKIN' YEARS?

Long version...

I read [a comment of mine][0] in piece of code I wrote over 9 years ago about how I could not figure how to get the ToolStrip work reliably. Thinking I was probably overlooking something then, I investigated. What follows, is my story...

All I wanted was a toolbar that would host a few buttons that are loaded at runtime.

As I had a 2 level hierarchy (think menu), I created a few 'toolstrips' that would fit in the toolbar (like any app would have). I thought it would be easy just to append these horizontally to form a single toolbar. No, this does not [work][1]. So after seeing the Load/SaveSettings methods in the ToolStripManager, I thought that would at least be decent workaround. This proved also not to work. After a few attempts, I gave up on the toolbar for my app thinking it was either me, .NET 2 or my 'Windows 2006 OS'.

Fast-forward 9 and a bit years to today.

No, I was not an idiot.

This project was created in the VS2015 IDE using the designer. Everything has the names and stuff required.

Just build and run the project. I configured it so it will be .NET 3.5 compatible as there is a bunch of differences in the bugs observed. (If you mess in the designer, it will probably break the current start toolbar layout, possibly another bug.) You can change the preferred target runtime in the app.config.

When the app starts, it lays out the toolstrips in the toolbar as it was laid out in the designer (which does not display correctly since changing to a lesser runtime from .NET 4; same behavior though). 


  [0]: https://github.com/leppie/xacc.ide/commit/5ec1bcc8c327de261c26f9da303a2f1f42dc7203#diff-b82937c99997a202856090b7275039bc
  [1]: bug1
  [2]: bug2
  [3]: bug3
  [4]: bug4
  [5]: bug5
  


