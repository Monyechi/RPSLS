---

```markdown
# 🖐 RPSLS (Rock, Paper, Scissors, Lizard, Spock)

A console-based C# implementation of the extended classic game, **Rock, Paper, Scissors, Lizard, Spock**, made popular by *The Big Bang Theory*. This game introduces more complexity and reduces ties compared to the traditional version by including two additional gestures—Lizard and Spock.

## 🎮 Game Modes

- **Human vs. Computer (HvC)** – Play against an AI-controlled opponent.
- **Human vs. Human (HvH)** – Play against a friend on the same machine.

## 🧠 Game Logic

The winner is determined based on these rules:

- Rock crushes Scissors  
- Scissors cuts Paper  
- Paper covers Rock  
- Rock crushes Lizard  
- Lizard poisons Spock  
- Spock smashes Scissors  
- Scissors decapitates Lizard  
- Lizard eats Paper  
- Paper disproves Spock  
- Spock vaporizes Rock  

First to **3 points** wins the match.

---

## 🧱 Project Structure

| File         | Description |
|--------------|-------------|
| `Program.cs` | Entry point of the application. Instantiates the game and starts it. |
| `Game.cs`    | Controls the overall game flow including player turns, score tracking, rule display, and win logic. |
| `Player.cs`  | Abstract base class for players, holding common properties (name, score, gestures) and abstract methods. |
| `Human.cs`   | Handles human player's input, gesture selection, and naming. |
| `Computer.cs`| Inherits from `Player`, generates random moves for the computer opponent. |

---

## 🖥️ How to Run

### Prerequisites
- Visual Studio or any C# compatible IDE
- .NET SDK installed (targeting version compatible with your setup)

### Steps
1. **Clone the repo**:
   ```bash
   git clone https://github.com/Monyechi/RPSLS.git
   cd RPSLS
   ```

2. **Open the solution** in Visual Studio:
   - Double-click `RPSLS.sln` or open via File > Open > Project/Solution

3. **Build and Run**:
   - Click the green **Start** button or press `F5`

---

## 🧑‍💻 Gameplay Flow

1. Game starts and displays all the rules.
2. Player selects a mode (HvC or HvH).
3. Each round:
   - Both players pick a gesture.
   - The game compares gestures, displays a result message (e.g., "Spock vaporizes Rock"), and awards a point to the winner.
   - The current score is displayed.
4. The game continues until one player reaches **3 points**.
5. Winner is declared.

---

## 💡 Features & Highlights

- Fully interactive command-line interface.
- Random gesture selection for computer opponents.
- Handles invalid user inputs gracefully with recursion.
- Clean and modular class structure using OOP principles.
- Custom round result messages with detailed reasoning based on rules.

---

## 🚀 Possible Improvements

- Add game replay functionality at the end.
- Save and display score history.
- Implement a GUI version (WPF or Windows Forms).
- Refactor gesture logic using enums and dictionaries to improve scalability.

---

## 📜 License

This project is licensed under the MIT License. Feel free to modify, fork, or build upon it!

---

## ✨ Credits

Developed by **Monyechi**.  
Inspired by the extended RPSLS game from *The Big Bang Theory*.

---