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
        Rectangle[,] gligarRectangle;

        // These bytes tell the spriteBatch.Draw() what sourceRectangle to display.
        byte previousAnimationIndex;
        byte currentAnimationIndex;
        int direction;

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

            gligarRectangle = new Rectangle[8, 3];
            gligarRectangle[0, 0] = new Rectangle(90, 39, 29, 29); //abajo
            gligarRectangle[0, 1] = new Rectangle(126, 39, 33, 30);
            gligarRectangle[0, 2] = new Rectangle(162, 38, 35, 32);
            gligarRectangle[1, 0] = new Rectangle(91, 71, 34, 36); //arriba
            gligarRectangle[1, 1] = new Rectangle(126, 71, 34, 36);
            gligarRectangle[1, 2] = new Rectangle(164, 71, 34, 36);
            gligarRectangle[2, 0] = new Rectangle(98, 113, 25, 34);//izquierda
            gligarRectangle[2, 1] = new Rectangle(130, 110, 25, 36);
            gligarRectangle[2, 2] = new Rectangle(169, 109, 24, 36);
            gligarRectangle[3, 0] = new Rectangle(98, 151, 25, 34);//derecha
            gligarRectangle[3, 1] = new Rectangle(133, 149, 25, 36);
            gligarRectangle[3, 2] = new Rectangle(171, 149, 24, 36);
            gligarRectangle[4, 0] = new Rectangle(98, 185, 28, 38);//abajo-izquierda
            gligarRectangle[4, 1] = new Rectangle(133, 185, 28, 38);
            gligarRectangle[4, 2] = new Rectangle(172, 185, 28, 38);
            gligarRectangle[5, 0] = new Rectangle(102, 222, 28, 39);//abajo-derecha
            gligarRectangle[5, 1] = new Rectangle(136, 222, 28, 39);
            gligarRectangle[5, 2] = new Rectangle(173, 222, 28, 39);
            gligarRectangle[6, 0] = new Rectangle(99, 264, 27, 39);//arriba-izquierda
            gligarRectangle[6, 1] = new Rectangle(134, 264, 27, 39);
            gligarRectangle[6, 2] = new Rectangle(174, 264, 27, 39);
            gligarRectangle[7, 0] = new Rectangle(171, 149, 24, 36);//arriba-derecha
            gligarRectangle[7, 1] = new Rectangle(171, 149, 24, 36);
            gligarRectangle[7, 2] = new Rectangle(171, 149, 24, 36);

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
            gligarRectangle[direction, currentAnimationIndex],
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

            if (teclaPresionada.IsKeyDown(Keys.W))
            {
                gligarPosition.Y -= velocidadGlobal;
                direction = 1;
            }
            
            if (teclaPresionada.IsKeyDown(Keys.S))
            {
                gligarPosition.Y += velocidadGlobal;
                direction = 0;
            }

            if (teclaPresionada.IsKeyDown(Keys.A))
            {
                gligarPosition.X -= velocidadGlobal;
                direction = 2;
            }

            if (teclaPresionada.IsKeyDown(Keys.D))
            {
                gligarPosition.X += velocidadGlobal;
                direction = 3;
            }
            animation(gameTime);
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
