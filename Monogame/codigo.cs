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
            gligarRectangle[0] = new Rectangle(90, 39, 29, 29); //abajo
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

            movimientoTeclado(gameTime);
            //animation(gameTime);

            base.Update(gameTime);

        }

        protected override void Draw(GameTime gameTime)
        {

            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp);

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

            _spriteBatch.Draw(
            _gligar,
            gligarPosition,
            gligarRectangle[0],
            Color.White,
            0.0f,               // Rotación
            Vector2.Zero,       // Origen (pivote)
            2.0f,       // ESCALA (Aquí cambias el tamaño)
            SpriteEffects.None, // Efectos de espejo
            0.0f                // Capa de profundidad
            );

            _spriteBatch.End();
            base.Draw(gameTime);
        }
        void movimientoTeclado(GameTime gameTime)
        {
            float velocidadMovimiento = velocidadGlobal;
            KeyboardState teclaPresionada = Keyboard.GetState();

            if (teclaPresionada.IsKeyDown(Keys.W) || teclaPresionada.IsKeyDown(Keys.Up))
            {
                gligarPosition.Y -= velocidadGlobal;
                currentAnimationIndex = 1;
            }

            if (teclaPresionada.IsKeyDown(Keys.S) || teclaPresionada.IsKeyDown(Keys.Down))
            {
                gligarPosition.Y += velocidadGlobal;
                currentAnimationIndex = 0;
            }

            if (teclaPresionada.IsKeyDown(Keys.A) || teclaPresionada.IsKeyDown(Keys.Left))
            {
                gligarPosition.X -= velocidadGlobal;
                currentAnimationIndex = 2;
            }

            if (teclaPresionada.IsKeyDown(Keys.D) || teclaPresionada.IsKeyDown(Keys.Right))
            {
                gligarPosition.X += velocidadGlobal;
                currentAnimationIndex = 3;
            }
        }

        void animation(GameTime gameTime)
        {
            if (timer > threshold)
            {
                if (currentAnimationIndex == 1)
                {
                    if (previousAnimationIndex == 0)
                    {
                        currentAnimationIndex = 2;
                    }
                    else
                    {
                        currentAnimationIndex = 0;
                    }
                    previousAnimationIndex = currentAnimationIndex;
                }
                else
                {
                    currentAnimationIndex = 1;
                }
                timer = 0;
            }
            else
            {
                timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }
        }
    }
}
