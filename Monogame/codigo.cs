using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _background;

        private Texture2D _gligar;
        private Texture2D _wooper;

        private Vector2 gligarPosition;
        private Vector2 wooperPosition;
        private float velocidadGlobal = 5.0f;
        float timer;

        // An int that is the threshold for the timer.
        int threshold;

        // A Rectangle array that stores sourceRectangles for animations.
        Rectangle[] gligarRectangle;

        // These bytes tell the spriteBatch.Draw() what sourceRectangle to display.
        byte previousAnimationIndex;
        byte currentAnimationIndex;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _background = Content.Load<Texture2D>("Fondo/Fondo");
            _gligar = Content.Load<Texture2D>("GligarPlantilla/PlantillaGligar");
            _wooper = Content.Load<Texture2D>("GengarPlantilla/PlantillaGengar");

            timer = 0;

            threshold = 250;

            gligarRectangle = new Rectangle[4];
            gligarRectangle[0] = new Rectangle(85, 40, 32, 32); //abajo
            gligarRectangle[1] = new Rectangle(85, 72, 32, 32); //arriba
            gligarRectangle[2] = new Rectangle(85, 104, 32, 32);//izquierda
            gligarRectangle[3] = new Rectangle(85, 136, 32, 32);//derecha

            previousAnimationIndex = 2;
            currentAnimationIndex = 1;


        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            movimientoTeclado();

            base.Update(gameTime);

        }

        protected override void Draw(GameTime gameTime)
        {

            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw
            (_background,
            new Vector2(-75, 0),
            null,
            Color.White,
            0.0f,
            Vector2.Zero,
            2.2f,
            SpriteEffects.None,
            0.0f);
            _spriteBatch.Draw(_gligar, gligarPosition, gligarRectangle[0], Color.White);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
        void movimientoTeclado()
        {
            float velocidadMovimiento = velocidadGlobal;
            KeyboardState teclaPresionada = Keyboard.GetState();

            if (teclaPresionada.IsKeyDown(Keys.W) || teclaPresionada.IsKeyDown(Keys.Up))
            {
                gligarPosition.Y -= velocidadGlobal;
            }

            if (teclaPresionada.IsKeyDown(Keys.S) || teclaPresionada.IsKeyDown(Keys.Down))
            {
                gligarPosition.Y += velocidadGlobal;
            }

            if (teclaPresionada.IsKeyDown(Keys.A) || teclaPresionada.IsKeyDown(Keys.Left))
            {
                gligarPosition.X -= velocidadGlobal;
            }

            if (teclaPresionada.IsKeyDown(Keys.D) || teclaPresionada.IsKeyDown(Keys.Right))
            {
                gligarPosition.X += velocidadGlobal;
            }
        }
    }
}
