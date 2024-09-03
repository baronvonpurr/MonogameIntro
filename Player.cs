using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonogameIntro
{
    public class Player:BaseClass
    {

        public Player(Texture2D texture):base(texture, new Vector2(400,240)){
            color = Color.Green;
        }

        public void Update(){
        KeyboardState kState = Keyboard.GetState();
        if(kState.IsKeyDown(Keys.LeftShift)){
            if(kState.IsKeyDown(Keys.W)){
                position.Y -= 4;
            }
            if(kState.IsKeyDown(Keys.S)){
                position.Y += 4;
            }
            if(kState.IsKeyDown(Keys.A)){
                position.X -= 4;
            }
            if(kState.IsKeyDown(Keys.D)){
                position.X += 4;
            }
        }
        else{
            if(kState.IsKeyDown(Keys.W)){
                position.Y -= 2;
            }
            if(kState.IsKeyDown(Keys.S)){
                position.Y += 2;
            }
            if(kState.IsKeyDown(Keys.A)){
                position.X -= 2;
            }
            if(kState.IsKeyDown(Keys.D)){
                position.X += 2;
            }
        }
        }
    }
}