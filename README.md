# siema

### 1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?
merge commit występuje gdy się zrobi:
```
git merge --no-ff feature-max
```

no a jesli sie zrobi samo `git merge (gałąź)` to wtedy on połączy gałęzie bez dodatkowego commitu

### 2. Czym w praktyce różni się merge od rebase?
merge robimy częściej i jest bezpieczniejszy a rebase daje większą możliwość edycji repozytorium ale można coś popsuć. np. możemy rebasem zmienić opis starego starego commitu.

### 3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?
no wyedytowałem plik i ja akurat przyjąłem zmiany z szybszej wersji programu. potem push i działa
