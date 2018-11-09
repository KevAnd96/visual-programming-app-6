# visual-programming-app-6
A simple trivia app.

# How to use GitHub
[![Github Tutorial](https://img.youtube.com/vi/CsDbUNS_mRI/maxresdefault.jpg)](https://youtu.be/CsDbUNS_mRI)

## Updating your fork
You will want to update your fork both before you begin working on a new feature and before submitting
your PR.

In Github Desktop, click the Repository tab, then "Open in Command Prompt". If you do not have Git installed,
it will prompt you to do that. Install it, then in Command Prompt run:

```bash
git fetch upstream
git merge upstream/master
```

If it tells you that you have new changes, either commit or discard those changes, then try again.

If it tells you that `upstream` does not exist, run

```
git remote add upstream https://github.com/astroengisci/visual-programming-app-6.git
```

If you have merge conflicts, you will need to resolve those by committing the merge and then 
manually adjusting the files. Visual Studio will help you here by not compiling until you have
successfully resolved the conflicts.
